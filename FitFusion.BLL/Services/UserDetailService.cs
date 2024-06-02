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

public class UserDetailService
{
    private readonly IUserDetailRepostory _repostory;
    public UserDetailService()
    {
        _repostory = new UserDetailRepostory();
    }

    public bool Add(UserDetail userDetail)
    {
        if (_repostory.Add(userDetail)) return true;
        else
            return false;
    }
    public bool Delete(UserDetail userDetail)
    {
        if (_repostory.Delete(userDetail)) return true;
        else return false;
    }
    public bool Update(UserDetail userDetail)
    {
        if (_repostory.Update(userDetail)) return true;
        else return false;
    }

    public UserDetail Get(Expression<Func<UserDetail, bool>> expression)
    {
        return _repostory.Get(expression);
    }
    public UserDetail Get(Guid id)
    {
        return _repostory.Get(id);
    }
    public IEnumerable<UserDetail> GetAll(Expression<Func<UserDetail, bool>> expression)
    {
        return _repostory.GetAll(expression);
    }
}
