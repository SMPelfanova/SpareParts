using SP.Data.Models;
using SP.Repo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Repo.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _dbContex;
        public CategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContex = dbContext;

        }
        public IEnumerable<Category> GetAllCategoriesByVehicleType(int vehicleType)
        {
            return _dbContex.Caterogories;
        }

    }
}
