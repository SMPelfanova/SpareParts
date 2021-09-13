using SP.Data;
using SP.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Repo.Contracts
{
    public interface IPartRepository:IRepository<Part>
    {
        Part GetPartById(int id);
        void AddPart(Part part);
        void UpdatePart(Part part);
    }
}
