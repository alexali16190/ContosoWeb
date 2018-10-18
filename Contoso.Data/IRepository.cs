using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        T GetById(int Id);

        IEnumerable<T> GetAll();

        T Get(Expression<Func<T, bool>> where);

        IQueryable<T> GetAllData();

        void SaveChanges();
    }
}
