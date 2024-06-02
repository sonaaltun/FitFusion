using FitFusion.DAL.Repostories.Concrate;
using FitFusion.DAL.Repostories.Interfaces;
using FitFusion.Entity.NewEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.BLL.Services;

public class CategoryFoodService
{
    private readonly ICategoryFoodRepostory _repostory;
    public CategoryFoodService()
    {
        _repostory = new CategoryFoodRepostory();
    }

    public bool Add(CategoryFood foodCategory)
    {
        if (_repostory.Add(foodCategory)) return true;
        else
            return false;
    }
    public bool Delete(CategoryFood foodCategory)
    {
        if (_repostory.Delete(foodCategory)) return true;
        else return false;
    }
    public bool Update(CategoryFood foodCategory)
    {
        if (_repostory.Update(foodCategory)) return true;
        else return false;
    }

    public CategoryFood Get(Expression<Func<CategoryFood, bool>> expression)
    {
        return _repostory.Get(expression);
    }
    public CategoryFood Get(Guid id)
    {
        return _repostory.Get(id);
    }
    public IEnumerable<CategoryFood> GetAll(Expression<Func<CategoryFood, bool>> expression)
    {
        return _repostory.GetAll(expression);
    }
}