using FitFusion.BLL.Services;
using FitFusion.Entity.NewEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using FitFusion.BLL.VMs;
using AutoMapper;
using FitFusion.BLL.Mapper;
using System.Collections;

namespace FitFusion.Presentation.Controller;

public class FoodController
{
    private readonly FoodService _foodService;
    private readonly CategoryFoodService _categoryFoodService;
    private readonly IMapper _mapper;
    public FoodController()
    {
        _foodService = new FoodService();
        _categoryFoodService = new CategoryFoodService();
        var config = new MapperConfiguration(cfg => { cfg.AddProfile<MapperProfile>(); });
        _mapper = config.CreateMapper();
    }

    public bool AddFood(User user, byte[] imageBytes, CategoryVm categoryVm, string name, string caloriesPerServing, string protein, string fat, string carbonHydrat)
    {
        if (user == null || categoryVm == null || name == null || caloriesPerServing == null || protein == null || fat == null || carbonHydrat == null || imageBytes==null)
        {
            MessageBox.Show("Please fill in all fields!");
            return false;
        }


        //textbox'dan gelen verilerin geçerli değerler olup olmadığını kontrol ediyoruz. Örneğin calorie text box'ına yazı karakteri girilirse kabul edilmeyecek.
        else if (Regex.IsMatch(caloriesPerServing, @"^\d+$") && Regex.IsMatch(protein, @"^\d+$") && Regex.IsMatch(fat, @"^\d+$") && Regex.IsMatch(carbonHydrat, @"^\d+$") && user.IsAdmin ==false)
        {
            Food food = new Food()
            {
                CaloriesPerServing = Convert.ToInt32(caloriesPerServing),
                Protein = Convert.ToDouble(protein),
                Fat = Convert.ToDouble(fat),
                Carbonhydrat = Convert.ToDouble(carbonHydrat),
                Name = name,
                UserId = user.Id,
                ImageData= imageBytes,
            };

            _foodService.Add(food);

            CategoryFood categoryFood = new CategoryFood()
            {
                CaloriesPerServing = Convert.ToInt32(caloriesPerServing),
                Protein = Convert.ToDouble(protein),
                Fat = Convert.ToDouble(fat),
                Carbonhydrat = Convert.ToDouble(carbonHydrat),
                CategoryId = categoryVm.Id,
                Name = name,
                FoodId = food.Id,

            };
            _categoryFoodService.Add(categoryFood);
            MessageBox.Show("The food added succesfully");
            return true;
        }

        else if (Regex.IsMatch(caloriesPerServing, @"^\d+$") && Regex.IsMatch(protein, @"^\d+$") && Regex.IsMatch(fat, @"^\d+$") && Regex.IsMatch(carbonHydrat, @"^\d+$") && user.IsAdmin == true)
        {
            Food food = new Food()
            {
                CaloriesPerServing = Convert.ToInt32(caloriesPerServing),
                Protein = Convert.ToDouble(protein),
                Fat = Convert.ToDouble(fat),
                Carbonhydrat = Convert.ToDouble(carbonHydrat),
                Name = name,
                UserId = Guid.Empty, //admin'in eklediği yemekler'e user id eklemiyoruz. Böylelikle tüm kullanıcıların ekranlarında admin'in eklediği yemekler görünebiliyor.
                ImageData = imageBytes,
            };

            _foodService.Add(food);

            CategoryFood categoryFood = new CategoryFood()
            {
                CaloriesPerServing = Convert.ToInt32(caloriesPerServing),
                Protein = Convert.ToDouble(protein),
                Fat = Convert.ToDouble(fat),
                Carbonhydrat = Convert.ToDouble(carbonHydrat),
                CategoryId = categoryVm.Id,
                Name = name,
                FoodId = food.Id,

            };
            _categoryFoodService.Add(categoryFood);
            MessageBox.Show("The food added succesfully");
            return true;
        }

        else
        {
            MessageBox.Show("Please enter valid values!");
            return false;
        }
    }

    public List<FoodVm> GetFoodList(User user)
    {
        return _mapper.Map<List<FoodVm>>(_foodService.GetAll(x => x.UserId == user.Id || x.UserId == Guid.Empty));

    }

    public Food GetFood(Guid id)
    {
        return _foodService.Get(id);
    }

    public bool RemoveFood(Guid id)
    {
        var selectedFood = _foodService.Get(id);
        _foodService.Delete(selectedFood);
        return true;
    }

    public List<FoodVm> GetFoodList()
    {
        return _mapper.Map<List<FoodVm>>(_foodService.GetAll(x => x.Statu != Entity.Enums.Statu.Deleted));
    }

    public byte[] ConvertImageToBytes(string filePath)
    {
        if(filePath != null)
        {
            byte[] imageData;
            using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                imageData = new byte[stream.Length];
                stream.Read(imageData, 0, (int)stream.Length);
            }
            return imageData;
        }
        else
        { 
            return null;
        }
       
    }

    public Image ConvertBytesToImage(byte[] imageData)
    {
        using (MemoryStream ms = new MemoryStream(imageData))
        {
            Image image = Image.FromStream(ms);
            return image;
        }
    }

    public List<FoodVm> GetSearchedFoods(string searchKeyword)
    {
        return _mapper.Map<List<FoodVm>>(_foodService.GetAll(x=> x.Statu!= Entity.Enums.Statu.Deleted && x.Name.Contains(searchKeyword)));
    }

    public void UpdateFood(Food food)
    {
        _foodService.Update(food);
        MessageBox.Show("The food updated succesfully");

    }
}