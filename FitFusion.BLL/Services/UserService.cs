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

public class UserService
{
    private readonly IUserRepostory _repostory;
    public UserService()
    {
        _repostory = new UserRepostory();
    }

    public bool Add(User user)
    {
        if (_repostory.Add(user)) return true;
        else
            return false;
    }
    public bool Delete(User user)
    {
        if (_repostory.Delete(user)) return true;
        else return false;
    }
    public bool Update(User user)
    {
        if (_repostory.Update(user)) return true;
        else return false;
    }

    public User Get(Expression<Func<User, bool>> expression)
    {
        return _repostory.Get(expression);
    }
    public User Get(Guid id)
    {
        return _repostory.Get(id);
    }
    public IEnumerable<User> GetAll(Expression<Func<User, bool>> expression)
    {
        return _repostory.GetAll(expression);
    }
}
