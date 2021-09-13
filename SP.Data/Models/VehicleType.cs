using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Data.Models
{
    public class VehicleType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Vehicle> Vehicle{ get; set; }
        public ICollection<VehicleTypeCategory> VehicleTypeCategories { get; set; }
    }
}
