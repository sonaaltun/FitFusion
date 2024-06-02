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

public class UserMealService
{
    private readonly IUserMealRepostory _repostory;
    public UserMealService()
    {
        _repostory = new UserMealRepostory();
    }

    public bool Add(UserMeal userMeal)
    {
        if (_repostory.Add(userMeal)) return true;
        else
            return false;
    }
    public bool Delete(UserMeal userMeal)
    {
        if (_repostory.Delete(userMeal)) return true;
        else return false;
    }
    public bool Update(UserMeal userMeal)
    {
        if (_repostory.Update(userMeal)) return true;
        else return false;
    }

    public UserMeal Get(Expression<Func<UserMeal, bool>> expression)
    {
        return _repostory.Get(expression);
    }
    public UserMeal Get(Guid id)
    {
        return _repostory.Get(id);
    }
    public IEnumerable<UserMeal> GetAll(Expression<Func<UserMeal, bool>> expression)
    {
        return _repostory.GetAll(expression);
    }
}
