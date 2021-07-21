using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FrontDeskApp.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        List<TEntity> GetAll();
        List<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        void Add(TEntity entity);
        void AddRange(List<TEntity> entities);
        void Delete(TEntity entity);
        void DeleteRange(List<TEntity> entities);
        void Save();
    }
}
