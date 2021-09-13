using SP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Repo.Contracts
{
    public interface IRepository<T> where T:class
    {
        Task<IEnumerable<T>> GetAllAsync();
        IEnumerable<T> GetAll(); 
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> Query();

    }
}
