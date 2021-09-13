using SP.Data;
using SP.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Repo.Contracts
{
    public interface IVehicleRepository: IRepository<Vehicle>
    {
        IEnumerable<Vehicle> GetAllVehiclesByBrand(int brandId);
    }
}
