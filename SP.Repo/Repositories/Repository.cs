using Microsoft.EntityFrameworkCore;
using SP.Data;
using SP.Repo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Repo.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> _entities;
        public Repository(ApplicationDbContext dbContext)
        {
            _entities = dbContext.Set<T>();
        }

        public void Add(T entity)
        {
            _entities.Add(entity);
        }

        public void Delete(T entity)
        {
            _entities.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
           return _entities.ToList();
        }
        
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _entities.ToListAsync();
        }
        
        public void Update(T entity)
        {
            _entities.Update(entity);
        }
        
        public IQueryable<T> Query()
        {
            throw new NotImplementedException();
        }

    }
}
