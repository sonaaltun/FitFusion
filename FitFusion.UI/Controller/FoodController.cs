using AutoMapper;
using FitFusion.BLL.Mapper;
using FitFusion.BLL.Services;
using FitFusion.BLL.VMs;
using FitFusion.Entity.NewEntity;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.UI.Controller;

public class FoodController
{
    private readonly FoodService _foodService;
    private readonly CategoryService _categoryService;
    private readonly FoodCategoryService _foodCategoryService;
    private readonly IMapper _mapper;
    public FoodController()
    {
        _foodService = new FoodService();
        _categoryService = new CategoryService();
        _foodCategoryService = new FoodCategoryService();
        var config = new MapperConfiguration(cfg => { cfg.AddProfile<MapperProfile>(); });
        _mapper = config.CreateMapper();
    }

    public void AddFood(User user ,string foodName, int caloriesPerServing, double protein, double fat, double carbonhydrat,  Category selectedCategory)
    {

        if (foodName == null || caloriesPerServing == null || selectedCategory == null || protein == null|| fat == null || carbonhydrat == null)
        {
            MessageBox.Show("Tüm alanları doldurun.");
        }
        else
        {

            //Food food = new Food()
            //{
            //    Name=foodName,
            //    Description=description,
            //};
            //_foodService.Add(food);

            CategoryFood categoryCategory = new CategoryFood()
            {
                CaloriesPerServing = caloriesPerServing,
                Protein = protein,
                Fat = fat,
                Carbonhydrat = carbonhydrat,
                Name = foodName,
                Category = selectedCategory,
                Food = new Food()
                {
                    CaloriesPerServing=caloriesPerServing,
                    Protein=protein,
                    Fat = fat,
                    Carbonhydrat=carbonhydrat,
                    Name = foodName,
                    
                },
                User = user,
                UserId = user.Id

            };


            _foodCategoryService.Add(categoryCategory);

            MessageBox.Show("Food ekleme işlemi başarılı.");
        }
    }
    public List<FoodCategoryVm> GetCategoryFoods(Expression<Func<CategoryFood, bool>> expression)
    {
        return _mapper.Map<List<FoodCategoryVm>>(_foodCategoryService.GetAll(expression));
    }
    public FoodCategoryVm GetCategoryFood(Guid id)
    {
        return _mapper.Map<FoodCategoryVm>(_foodCategoryService.Get(id));
    }
}
