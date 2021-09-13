using Microsoft.EntityFrameworkCore;
using SP.Data;
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
    public class PartRepository: Repository<Part>, IPartRepository
    {
        private readonly ApplicationDbContext dbContex;
        public PartRepository(ApplicationDbContext _dbContex) :base(_dbContex)
        {
            dbContex = _dbContex;
        }
        public Part GetPartById(int id)
        {
            var part = dbContex.Parts.FirstOrDefault(x => x.PartId == id);
            part.ManufId = part.CurrentManufacturerId;

            return part;
        }
        public void AddPart(Part part)
        {
            part.CurrentManufacturerId = part.ManufId;
            dbContex.Parts.Add(part);
            
        }
        public void UpdatePart(Part part)
        {
            part.CurrentManufacturerId = part.ManufId;
            dbContex.Parts.Update(part);
        }
  
    }
}
