using SP.Data.Models;
using SP.Repo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Repo.Repositories
{
    public class VehicleRepository : Repository<Vehicle>, IVehicleRepository
    {
        private readonly ApplicationDbContext dbContex;
        public VehicleRepository(ApplicationDbContext unitOfWork) : base(unitOfWork)
        {
            dbContex = unitOfWork;
        }
        public IEnumerable<Vehicle> GetAllVehiclesByBrand(int brandId)
        {
            return dbContex.Vehicles.Where(x=>x.VehicleBrand.Id == brandId).ToList();
        }

    }
}
