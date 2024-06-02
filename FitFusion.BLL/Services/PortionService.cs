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

public class PortionService
{
    private readonly IPortionRepostory _repostory;
    public PortionService()
    {
        _repostory = new PortionRepostory();
    }

    public bool Add(Portion portion)
    {
        if (_repostory.Add(portion)) return true;
        else
            return false;
    }
    public bool Delete(Portion portion)
    {
        if (_repostory.Delete(portion)) return true;
        else return false;
    }
    public bool Update(Portion portion)
    {
        if (_repostory.Update(portion)) return true;
        else return false;
    }

    public Portion Get(Expression<Func<Portion, bool>> expression)
    {
        return _repostory.Get(expression);
    }
    public Portion Get(Guid id)
    {
        return _repostory.Get(id);
    }
    public IEnumerable<Portion> GetAll(Expression<Func<Portion, bool>> expression)
    {
        return _repostory.GetAll(expression);
    }
}
