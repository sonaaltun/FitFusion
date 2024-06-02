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

public class CategoryController
{
    private readonly CategoryService _categoryService;
    private readonly IMapper _mapper;
    public CategoryController()
    {
        var config = new MapperConfiguration(cfg => { cfg.AddProfile<MapperProfile>(); });
        _mapper = config.CreateMapper();
        _categoryService = new CategoryService();
    }

    public List<CategoryVm> GetCategories(Expression<Func<Category, bool>> expression)
    {
        
        return _mapper.Map<List<CategoryVm>>(_categoryService.GetAll(expression));
    }
    public Category GetCategory (CategoryVm categoryVm)
    {
        return _categoryService.Get(categoryVm.Id);
    }
}
