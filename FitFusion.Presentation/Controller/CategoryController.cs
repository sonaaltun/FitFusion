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

public class CategoryController
{
    private readonly CategoryService _categoryService;
    private readonly IMapper _mapper;
    public CategoryController()
    {
        _categoryService = new CategoryService();
        var config = new MapperConfiguration(cfg => { cfg.AddProfile<MapperProfile>(); });
        _mapper = config.CreateMapper();
    }

    public List<CategoryVm> GetCategories()
    {
        return _mapper.Map<List<CategoryVm>>(_categoryService.GetAll(x => x.Statu != Entity.Enums.Statu.Deleted));
    }
    public Category GetCategory(CategoryVm categoryVm)
    {
        return _categoryService.Get(x=> x.Id == categoryVm.Id);
    }

    public bool AddCategory(string categoryName, string description)
    {
        if(categoryName ==string.Empty || description == string.Empty)
        {
            MessageBox.Show("Category Name or Description can not be empty!");
        }
        else
        {
            Category category = new Category()
            {
                Description = description,
                CategoryName = categoryName
            };
            if (_categoryService.Add(category))
            {
                MessageBox.Show("Category added succesfully!");
                return true;
            }
            else

                return false;
        }
        return false;


    }
    public void RemoveCategory(Guid id)
    {
       var selectedCategory= _categoryService.Get(id);
        _categoryService.Delete(selectedCategory);
    }

    public Category GetCategory(Guid id)
    {
        return _categoryService.Get(id);
    }

    public void UpdateCategory(Category category)
    {
        _categoryService.Update(category);
        MessageBox.Show("Category updated succesully!");
    }
}
