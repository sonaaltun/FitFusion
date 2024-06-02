using AutoMapper;
using FitFusion.BLL.Mapper;
using FitFusion.BLL.Services;
using FitFusion.BLL.VMs;
using FitFusion.Entity.NewEntity;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.Presentation.Controller;

public class UserFoodController
{
    private readonly UserFoodService _userFoodService;
    private readonly IMapper _mapper;

    public UserFoodController()
    {
        _userFoodService = new UserFoodService();
        var config = new MapperConfiguration(cfg => { cfg.AddProfile<MapperProfile>(); });
        _mapper = config.CreateMapper();
    }

    public bool AddUserFood(User user, Food food, Portion portion, DateTime selectedTime, int portionAmount, string mealType)
    {
        if (food == null || portion == null || portionAmount == 0)
        {
            MessageBox.Show("Fill in all fields!");
            return false;
        }
        else if (portionAmount <= 0)
        {
            MessageBox.Show("The portion value must be a valid.");
            return false;
        }
        else
        {
            if (UnitOfWork.Instance.UserMealControllers.CheckUserMeal(user, selectedTime, mealType))
            {
                var selectedUserMeal = UnitOfWork.Instance.UserMealControllers.GetUserMeal(user, selectedTime.Date, mealType);
                UserFood userFood = new UserFood()
                {
                    UserMealId = selectedUserMeal.Id,
                    Name = food.Name,
                    PortionId = portion.Id,
                    FoodId = food.Id,
                    TotalCalories = food.CaloriesPerServing * (portion.Amount / 100) * portionAmount,
                    TotalCarbonhydrat = food.Carbonhydrat * (portion.Amount / 100) * portionAmount,
                    TotalFat = food.Fat * (portion.Amount / 100) * portionAmount,
                    TotalProtein = food.Protein * (portion.Amount / 100) * portionAmount,

                };

                selectedUserMeal.TotalProtein += userFood.TotalProtein;
                selectedUserMeal.TotalCarbonhydrat += userFood.TotalCarbonhydrat;
                selectedUserMeal.TotalFat += userFood.TotalFat;
                selectedUserMeal.TotalCalories += userFood.TotalCalories;

                UnitOfWork.Instance.UserMealControllers.UpdateUserMeal(selectedUserMeal);


                _userFoodService.Add(userFood);

                MessageBox.Show("The food has been successfully added.");
                return true;

            }
            else
            {
                UserMeal userMeal = new UserMeal()
                {
                    UserId = user.Id,
                    MealTime = selectedTime.Date,
                    MealType = mealType,
                    TotalCalories = 0,
                    TotalCarbonhydrat = 0,
                    TotalFat = 0,
                    TotalProtein = 0,

                };

                UnitOfWork.Instance.UserMealControllers.AddUserMeal(userMeal);

                UserFood userFood = new UserFood()
                {
                    UserMealId = userMeal.Id,
                    Name = food.Name,
                    PortionId = portion.Id,
                    FoodId = food.Id,
                    TotalCalories = food.CaloriesPerServing * (portion.Amount / 100) * portionAmount,
                    TotalCarbonhydrat = food.Carbonhydrat * (portion.Amount / 100) * portionAmount,
                    TotalFat = food.Fat * (portion.Amount / 100) * portionAmount,
                    TotalProtein = food.Protein * (portion.Amount / 100) * portionAmount,
                };

                _userFoodService.Add(userFood);

                userMeal.TotalProtein = userFood.TotalProtein;
                userMeal.TotalCalories = userFood.TotalCalories;
                userMeal.TotalFat = userFood.TotalFat;
                userMeal.TotalCarbonhydrat = userFood.TotalCarbonhydrat;

                UnitOfWork.Instance.UserMealControllers.UpdateUserMeal(userMeal);

                MessageBox.Show("The food has been successfully added.");

                return true;
            }
        }
    }

    public List<UserFoodVm> GetMealUserFoods(User user, string mealType, DateTime selectedTime)
    {
        var selectedMeal = UnitOfWork.Instance.UserMealControllers.GetUserMeal(user, selectedTime.Date, mealType);

        if (selectedMeal != null)
        {
            return _mapper.Map<List<UserFoodVm>>(_userFoodService.GetAll(x => x.UserMealId == selectedMeal.Id && x.Statu != Entity.Enums.Statu.Deleted));
        }
        else
        {
            return new List<UserFoodVm> { };


        }
    }



    // tupple metod ile birden çok değeri return edebiliyoruz.
    public (int, double, double, double) GetSelectedTimeUserFoods(User user, DateTime selectedDate)
    {
        var mealList = UnitOfWork.Instance.UserMealControllers.GetUserMealForAnalyze(user, selectedDate);
        var calories = 0;
        double fat = 0;
        double protein = 0;
        double carbonhydrat = 0;
        foreach (var meal in mealList)
        {
            calories += meal.TotalCalories;
            fat += meal.TotalFat;
            protein += meal.TotalProtein;
            carbonhydrat += meal.TotalCarbonhydrat;
        }

        return (calories, fat, protein, carbonhydrat);
    }

    public bool RemoveUserFood(Guid id)
    {
        var selectedFood = _userFoodService.Get(id);
        _userFoodService.Delete(selectedFood);
        return true;
    }

    public List<UserFood> GetAllUserFoods()
    {
        return _userFoodService.GetAll(x => x.Statu != Entity.Enums.Statu.Deleted).ToList();
    }



    public List<FoodReportVm> GetAllFoodsReports(DateTime selectedFirstDate, DateTime selectedSeconDate)
    {
        var foodReports = new List<FoodReportVm>();
        var allUserFoods = new List<UserFood>();
        var selectedFoods = UnitOfWork.Instance.FoodControllers.GetFoodList();
        var selectedMeals = UnitOfWork.Instance.UserMealControllers.GetSelectedTimeUserMeals(selectedFirstDate, selectedSeconDate);
        foreach (var meal in selectedMeals)
        {
            allUserFoods.AddRange(_userFoodService.GetAll(x => x.UserMealId == meal.Id));
        }

        foreach (var food in selectedFoods)
        {
            foreach (var userFood in allUserFoods.Where(x => x.FoodId == food.Id))
            {
                if (foodReports.Any(x => x.FoodId == food.Id))
                {
                    var selectedFoodReport = foodReports.FirstOrDefault(x => x.FoodId == food.Id);
                    var index = foodReports.IndexOf(selectedFoodReport);
                    selectedFoodReport.TotalAmount += (userFood.TotalCalories / food.CaloriesPerServing) * 100;
                    foodReports[index] = selectedFoodReport;

                }
                else
                {
                    FoodReportVm foodReportVm = new FoodReportVm()
                    {
                        FoodId = food.Id,
                        FoodName = food.Name,
                        TotalAmount = (userFood.TotalCalories / food.CaloriesPerServing) * 100
                    };
                    foodReports.Add(foodReportVm);
                }
            }
        }
        return foodReports;
    }

    public List<MealFoodReportVm> GetAllFoodsReports(DateTime selectedFirstDate, DateTime selectedSeconDate, string mealType)
    {
        var foodReports = new List<MealFoodReportVm>();
        var allUserFoods = new List<UserFood>();
        var selectedFoods = UnitOfWork.Instance.FoodControllers.GetFoodList();
        var selectedMeals = UnitOfWork.Instance.UserMealControllers.GetSelectedTimeUserMeals(selectedFirstDate, selectedSeconDate, mealType);
        foreach (var meal in selectedMeals)
        {
            allUserFoods.AddRange(_userFoodService.GetAll(x => x.UserMealId == meal.Id));
        }

        foreach (var food in selectedFoods)
        {
            foreach (var userFood in allUserFoods.Where(x => x.FoodId == food.Id))
            {
                if (foodReports.Any(x => x.FoodId == food.Id))
                {
                    var selectedFoodReport = foodReports.FirstOrDefault(x => x.FoodId == food.Id);
                    var index = foodReports.IndexOf(selectedFoodReport);
                    selectedFoodReport.TotalAmount += (userFood.TotalCalories / food.CaloriesPerServing) * 100;
                    foodReports[index] = selectedFoodReport;

                }
                else
                {
                    MealFoodReportVm vm = new MealFoodReportVm()
                    {
                        MealType = mealType,
                        FoodName = food.Name,
                        TotalAmount = (userFood.TotalCalories / food.CaloriesPerServing) * 100,
                        FoodId = food.Id,
                        
                    };
                    foodReports.Add(vm);

                }
            }
        }
        return foodReports;
    }




}
