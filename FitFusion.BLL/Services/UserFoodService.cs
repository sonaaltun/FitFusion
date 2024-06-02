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

public class UserFoodService
{
    private readonly IUserFoodRepostory _repostory;
    public UserFoodService()
    {
        _repostory = new UserFoodRepostory();
    }

    public bool Add(UserFood foodPortion)
    {
        if (_repostory.Add(foodPortion)) return true;
        else
            return false;
    }
    public bool Delete(UserFood foodPortion)
    {
        if (_repostory.Delete(foodPortion)) return true;
        else return false;
    }
    public bool Update(UserFood foodPortion)
    {
        if (_repostory.Update(foodPortion)) return true;
        else return false;
    }

    public UserFood Get(Expression<Func<UserFood, bool>> expression)
    {
        return _repostory.Get(expression);
    }
    public UserFood Get(Guid id)
    {
        return _repostory.Get(id);
    }
    public IEnumerable<UserFood> GetAll(Expression<Func<UserFood, bool>> expression)
    {
        return _repostory.GetAll(expression);
    }
}
