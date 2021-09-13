using SP.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Service
{
    public interface IManufacturerService
    {
        IEnumerable<PartManufacturer> GetManufacturersPart(int manufId);
        PartManufacturer GetManufacturerById(int manufId);

    }
}
