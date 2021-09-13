using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SP.Data.Models
{
    public class Part
    {
        public int PartId { get; set; }
        [NotMapped]
        public int ManufId { get; set; }
        public string SerialNr { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public decimal Price { get; set; }
        public float Weight { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime CreatedDate { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
        public int? RelatedPartId { get; set; }
        
        public int CurrentManufacturerId { get; set; }
        public PartManufacturer PartManufacturer { get; set; }
        [JsonIgnore]
        public ICollection<VehiclePart> VehicleParts { get; set; }
        //[JsonIgnore]
        //public ICollection<ManufacturerPart> ManufacturerParts { get; set; }
        [JsonIgnore]
        public ICollection<CategoryPart> CategoryParts { get; set; }

    }
}
