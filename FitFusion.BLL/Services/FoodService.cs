using FitFusion.DAL.Repostories.Concrate;
using FitFusion.DAL.Repostories.Interfaces;

using FitFusion.Entity.NewEntity;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.BLL.Services;

public class FoodService
{
    private readonly IFoodRepostory _repostory;
    public FoodService()
    {
        _repostory = new FoodRepostory();
    }

    public bool Add(Food food)
    {
        if (_repostory.Add(food)) return true;
        else
            return false;
    }
    public bool Delete(Food food)
    {
        if (_repostory.Delete(food)) return true;
        else return false;
    }
    public bool Update(Food food)
    {
        if (_repostory.Update(food)) return true;
        else return false;
    }

    public Food Get(Expression<Func<Food, bool>> expression)
    {
        return _repostory.Get(expression);
    }
    public Food Get(Guid id)
    {
        return _repostory.Get(id);
    }
    public List<Food> GetAll(Expression<Func<Food, bool>> expression)
    {
        return _repostory.GetAll(expression).ToList();
    }
}
