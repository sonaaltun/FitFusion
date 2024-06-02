using AutoMapper;
using FitFusion.BLL.Mapper;
using FitFusion.BLL.Services;
using FitFusion.BLL.VMs;
using FitFusion.Entity.NewEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.Presentation.Controller;

public class UserMealController
{
    private readonly UserMealService _userMealService;
    private readonly IMapper _mapper;
    public UserMealController()
    {
        _userMealService = new UserMealService();
        var config = new MapperConfiguration(cfg => { cfg.AddProfile<MapperProfile>(); });
        _mapper = config.CreateMapper();
    }

    public bool CheckUserMeal(User user, DateTime date, string mealType)
    {
        if (_userMealService.Get(x => x.UserId == user.Id && x.MealTime == date.Date && x.MealType == mealType) != null)
        {
            return true;
        }
        else { return false; }
    }

    public UserMeal GetUserMeal(User user, DateTime date, string mealType)
    {
        return _userMealService.Get(x => x.UserId == user.Id && x.MealTime == date.Date && x.MealType == mealType);
    }

    public bool UpdateUserMeal(UserMeal userMeal)
    {
        _userMealService.Update(userMeal);
        return true;
    }

    public bool AddUserMeal(UserMeal userMeal)
    {
        _userMealService.Add(userMeal);
        return true;
    }


    // metod dönüşünü List yapınca cast hatası alıyorum.
    public IEnumerable<UserMeal> GetUserMealForAnalyze(User loginUser, DateTime selectedDate)
    {
        return _userMealService.GetAll(x => x.UserId == loginUser.Id && x.MealTime.Date == selectedDate.Date);

    }

    public List<UserMealVm> GetUserMealVms(User loginUser, DateTime selectedDate)
    {
        return _mapper.Map<List<UserMealVm>>(_userMealService.GetAll(x => x.UserId == loginUser.Id && x.MealTime.Date == selectedDate.Date));
    }

    public List<UserMeal> GetSelectedTimeUserMeals(DateTime selectedTime1 , DateTime selectedTime2)
    {
        return _userMealService.GetAll(x=> x.MealTime>= selectedTime1.Date && x.MealTime<= selectedTime2.Date).ToList();
    }
    public List<UserMeal> GetSelectedTimeUserMeals(DateTime selectedTime1, DateTime selectedTime2, string mealType)
    {
        return _userMealService.GetAll(x => x.MealTime >= selectedTime1.Date && x.MealTime <= selectedTime2.Date && x.MealType ==mealType).ToList();
    }


    public List<UserReportVm> GetAllUserReports(DateTime selectedFirstDate, DateTime selectedSeconDate, string mealType)
    {
        var allUsers = UnitOfWork.Instance.UserControls.GetAllUsers();
        List<UserReportVm> usersReposrts = new List<UserReportVm>();
        var allUsersMeal = _userMealService.GetAll(x => (x.MealTime.Date >= selectedFirstDate.Date && x.MealTime.Date <= selectedSeconDate.Date) || (x.MealTime.Date >= selectedFirstDate.Date && x.MealTime.Date <= selectedSeconDate.Date && x.MealType == mealType));

        foreach (var user in allUsers)
        {
            foreach (var userMeal in allUsersMeal.Where(x => x.UserId == user.Id))
            {
                if (usersReposrts.Any(x => x.FullName == user.FirstName + " " + user.LastName))
                {
                    var selectedUserReport = usersReposrts.FirstOrDefault(x => x.FullName == user.FirstName + " " + user.LastName);
                    var index = usersReposrts.IndexOf(selectedUserReport);
                    selectedUserReport.TotalProtein += userMeal.TotalProtein;
                    selectedUserReport.TotalCarbonhydrat += userMeal.TotalCarbonhydrat;
                    selectedUserReport.TotalCalories += userMeal.TotalCalories;
                    selectedUserReport.TotalFat += userMeal.TotalFat;
                    usersReposrts[index] = selectedUserReport;

                }
                else
                {
                    UserReportVm userReportVm = new UserReportVm()
                    {
                        FullName = user.FirstName + " " + user.LastName,
                        TotalCalories = +userMeal.TotalCalories,
                        TotalCarbonhydrat = +userMeal.TotalCarbonhydrat,
                        TotalFat = +userMeal.TotalFat,
                        TotalProtein = +userMeal.TotalProtein,
                    };
                    usersReposrts.Add(userReportVm);
                }



            };


        }
        return usersReposrts;

    }

}


