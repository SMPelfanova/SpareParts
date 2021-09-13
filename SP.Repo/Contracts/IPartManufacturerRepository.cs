using SP.Data;
using SP.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Repo.Contracts
{
    public interface IPartManufacturerRepository : IRepository<PartManufacturer>
    {
        PartManufacturer GetManufacturerById(int manufacturerId);
        void AddManufacturerPart(PartManufacturer manufacturer);
        void UpdateManufacturerPart(PartManufacturer manufacturer);
        void Remove(int manufacturerId);
    }
}
