using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SP.Data.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Engine { get; set; }
        public string FuelType { get; set; }
        public int PowerHP { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime ModelYearFrom { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime ModelYearTo { get; set; }
    //    public int VehicleBrandsId { get; set; }
        public VehicleBrand VehicleBrand { get; set; }
      //  public int VehicleTypesId { get; set; }

        public VehicleType VehicleType { get; set; }
        public ICollection<VehiclePart> VehicleParts { get; set; }

    }
}
