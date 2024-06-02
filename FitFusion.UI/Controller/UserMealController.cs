using AutoMapper;
using FitFusion.BLL.Mapper;
using FitFusion.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.UI.Controller;

public class UserMealController
{
    private readonly UserMealService _userMealService;
    private readonly IMapper _mapper;
    public UserMealController()
    {
        var config = new MapperConfiguration(cfg => { cfg.AddProfile<MapperProfile>(); });
        _mapper = config.CreateMapper();
        _userMealService = new UserMealService();
    }
    public void AddUserMeal()
    {

    }
}
