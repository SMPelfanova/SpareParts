using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Data.Models
{
    public class VehicleTypeCategory
    {
        public int VehicleTypeId { get; set; }
        public VehicleType VehicleType { get; set; }
        ////many to many with category
        //// kategoriq chasti za dvigatel mojem da imame v koli i kamioni
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
