using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Data.Models
{
    public class VehiclePart
    {
        public string OEM { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        public int PartId { get; set; }
        public Part Part { get; set; }
    }
}
