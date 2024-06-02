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

public class CategoryService
{
    private readonly ICategoryRepostory _repostory;
    public CategoryService()
    {
        _repostory = new CategoryRepostory();
    }
    
    public bool Add (Category category)
    {
        if(_repostory.Add(category)) return true;
        else
        return false;
    }
    public bool Delete (Category category)
    {
        if(_repostory.Delete(category)) return true;
        else return false;
    }
    public bool Update (Category category)
    {
        if (_repostory.Update(category)) return true;
        else return false;
    }

    public Category Get(Expression<Func<Category, bool>> expression)
    {
        return _repostory.Get(expression);
    }
    public Category Get (Guid id)
    {
        return _repostory.Get(id);
    }
    public IEnumerable<Category> GetAll(Expression<Func<Category, bool>> expression)
    {
        return _repostory.GetAll(expression);
    }





}
