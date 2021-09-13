using SP.Repo.Contracts;
using SP.Repo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Repo
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext dbContext;
        public IPartRepository Parts => new PartRepository(dbContext);
        public IPartManufacturerRepository PartManufacturer => new PartManufacturerRepository(dbContext);
        public IVehicleRepository Vehicles =>  new VehicleRepository(dbContext);
        public IBrandRepository Brands => new BrandRepository(dbContext);
        public ICategoryRepository Categories => new CategoryRepository(dbContext);
        public UnitOfWork(ApplicationDbContext context)
        {
            this.dbContext = context;
        }
        public void Dispose()
        {
            this.dbContext.Dispose();
        }
        public async Task<bool> CommitAsync()
        {
            return await this.dbContext.SaveChangesAsync() > 0;
        }
        public bool Commit()
        {
            return dbContext.SaveChanges() > 0;
        }
    }
}
