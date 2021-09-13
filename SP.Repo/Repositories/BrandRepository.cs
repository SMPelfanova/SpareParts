using SP.Data.Models;
using SP.Repo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Repo.Repositories
{
    public class BrandRepository : Repository<VehicleBrand>, IBrandRepository
    {
        private readonly ApplicationDbContext _dbContex;
        public BrandRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContex = dbContext;
        }
    }
}
