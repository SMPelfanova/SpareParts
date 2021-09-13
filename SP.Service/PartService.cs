using SP.Data.Models;
using SP.Repo;
using SP.Repo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SP.Service
{
    public class PartService : IPartService
    {
        private IUnitOfWork _uow;
        private IManufacturerService manufacturerService;
        public PartService(IUnitOfWork unit, IManufacturerService manufacturer)
        {
            _uow = unit;
            manufacturerService = manufacturer;
        }

        public async Task<IEnumerable<VehicleBrand>> GetAllBrands()
        {
            return await _uow.Brands.GetAllAsync();
        }
        public async Task<IEnumerable<Part>> GetAllPartsAsync()
        {
            return await _uow.Parts.GetAllAsync();
        }
        public Part GetPartById(int id)
        {
            var part = _uow.Parts.GetPartById(id);          
            part.ManufId = part.CurrentManufacturerId;

            return part;
        }
        public async Task<bool> InsertPart(Part part)
        {
            try
            {
                _uow.Parts.AddPart(part);
            }
            catch (Exception)
            {
                return false;
            }

            return await _uow.CommitAsync();
        }
        public async Task<bool> UpdatePart(Part part)
        {
            _uow.Parts.UpdatePart(part);

            return await _uow.CommitAsync();
        }
        public bool RemovePart(int partId)
        {
            Part part = _uow.Parts.GetPartById(partId);

            _uow.Parts.Delete(part);

            return _uow.Commit();
        }
    }
}
