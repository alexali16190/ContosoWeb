using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Contoso.Model.Common;

namespace Contoso.Data
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly IDbSet<T> _dbSet;

        protected ContosoDbContext _db;

        public Repository(ContosoDbContext db)
        {
            _db = db;
            _dbSet = db.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return _dbSet.Where(where).FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public IQueryable<T> GetAllData()
        {
            return _dbSet.AsNoTracking();
        }

        public T GetById(int Id)
        {
            return _dbSet.Find(Id);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
        }
    }
}
