using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Repo.Contracts
{
    public interface IUnitOfWork: IDisposable
    {
        IPartManufacturerRepository PartManufacturer { get; }
        IBrandRepository Brands { get; }
        ICategoryRepository Categories { get; }
        IPartRepository Parts { get; }
        IVehicleRepository Vehicles { get; }
        Task<bool> CommitAsync();
        bool Commit();
    }
}