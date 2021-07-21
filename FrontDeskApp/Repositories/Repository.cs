using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;

namespace FrontDeskApp.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;

        public Repository(DbContext context)
        {
            Context = context;
        }

        public TEntity Get(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public List<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        public List<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate).ToList();
        }

        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public void AddRange(List<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);
        }
        
        public void Delete(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }
        public void DeleteRange(List<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
        }

        public void Save()
        {
            Context.SaveChanges();
        }        
    }
}
