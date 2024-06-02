using AutoMapper;
using FitFusion.BLL.VMs;
using FitFusion.Entity.NewEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.BLL.Mapper;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Category, CategoryVm>();
        CreateMap<User, UserVm>();
        CreateMap<Food, FoodVm>();
        CreateMap<CategoryFood, FoodCategoryVm>();
        CreateMap<Portion, PortionVm>();
        CreateMap<UserDetail, UserDetailVm>();
        CreateMap<UserMeal, UserMealVm>();
        CreateMap<UserFood, UserFoodVm>();
        CreateMap<UserMeal, UserReportVm>();

    }
}
