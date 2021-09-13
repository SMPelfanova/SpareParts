using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Data.Models
{
    public class VehicleBrand
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string LogoFileName { get; set; }
        public ICollection<Vehicle> Vehicle { get; set; }
    }
}
