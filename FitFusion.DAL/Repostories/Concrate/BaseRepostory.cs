using FitFusion.DAL.Context;
using FitFusion.DAL.Repostories.Interfaces;
using FitFusion.Entity.Base;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.DAL.Repostories.Concrate;

public abstract class BaseRepostory<T> : IBaseRepostory<T> where T : BaseEntity
{
    private readonly FitFusionDbContext _context;
    public BaseRepostory()
    {
        _context = new FitFusionDbContext();
    }
    public bool Add(T entity)
    {

            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return true;
    }

    public bool Delete(T entity)
    {
        try
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
            return true;
        }
        catch (Exception)
        {

            throw new Exception("There is an error occurred!");
        }
    }

    public T Get(Expression<Func<T, bool>> expression)
    {
        try
        {
             return _context.Set<T>().Where(expression).FirstOrDefault();

        }
        catch (Exception)
        {

            throw new Exception("There is an error occurred!");
        }
    }
    public IEnumerable<T> GetAll(Expression<Func<T, bool>> expression)
    {
        return _context.Set<T>().Where(expression);
    }

    public T Get(Guid id)
    {
        try
        {
            return _context.Set<T>().FirstOrDefault(x => x.Id == id);

        }
        catch (Exception)
        {

            throw new Exception("There is an error occurred!");
        }
        
    }

    public bool Update(T entity)
    {
        try
        {
             _context.Set<T>().Update(entity);
            _context.SaveChanges();
            return true;

        }
        catch (Exception)
        {

            throw new Exception("There is an error occurred!");
        }
    }
}
