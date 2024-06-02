using AutoMapper;
using FitFusion.BLL.Mapper;
using FitFusion.BLL.Services;
using FitFusion.BLL.VMs;
using FitFusion.Entity.NewEntity;
using FitFusion.Entity.NewEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.UI.Controller;

public class MealController
{
    private readonly MealService _mealService;
    private readonly IMapper _mapper;
    public MealController()
    {
        _mealService = new MealService();
        var config = new MapperConfiguration(cfg => { cfg.AddProfile<MapperProfile>(); });
        _mapper = config.CreateMapper();
    }
    public List<MealVm> GetMeals(Expression<Func<Meal, bool>> expression)
    {

        return _mapper.Map<List<MealVm>>(_mealService.GetAll(expression));
    }
}
