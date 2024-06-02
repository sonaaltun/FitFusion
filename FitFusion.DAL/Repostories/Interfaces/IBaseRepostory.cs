using FitFusion.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.DAL.Repostories.Interfaces;

public interface IBaseRepostory<T> where T : BaseEntity
{
    bool Add(T entity);
    bool Delete(T entity);
    bool Update(T entity);
    T Get(Expression<Func<T, bool>> expression);
    IEnumerable<T> GetAll(Expression<Func<T, bool>> expression);
    T Get(Guid id);
    
}
