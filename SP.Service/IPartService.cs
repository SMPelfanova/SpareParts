using SP.Data;
using SP.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SP.Service
{
    public interface IPartService
    {
        Task<IEnumerable<Part>> GetAllPartsAsync();
        Task<IEnumerable<VehicleBrand>> GetAllBrands();
        Task<bool> InsertPart(Part part);
        Task<bool> UpdatePart(Part part);
        Part GetPartById(int id);
        bool RemovePart(int partId);
    }
}
