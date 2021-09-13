using Microsoft.EntityFrameworkCore;
using SP.Data.Models;
using SP.Repo.Contracts;
using SP.Repo.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Repo.Repositories
{
    public class PartManufacturerRepository : Repository<PartManufacturer>, IPartManufacturerRepository
    {
        private readonly ApplicationDbContext dbContex;
        public PartManufacturerRepository(ApplicationDbContext _dbContex) : base(_dbContex)
        {
            dbContex = _dbContex;
        }

        public PartManufacturer GetManufacturerById(int manufacturerId)
        {
            return dbContex.PartManufacturers.Single(x => x.ManufacId == manufacturerId);
        }
        public void AddManufacturerPart(PartManufacturer manufacturer)
        {
            dbContex.PartManufacturers.Add(manufacturer);
        }

        public void UpdateManufacturerPart(PartManufacturer manufacturer)
        {      
            dbContex.PartManufacturers.Update(manufacturer);
        }
        public void Remove(int manufacturerId)
        {
            var mnufPart = dbContex.PartManufacturers.Single(x => x.ManufacId == manufacturerId);
            dbContex.PartManufacturers.Remove(mnufPart);
        }

    }
}
