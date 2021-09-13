using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Data.Models
{
    public class PartManufacturer
    {
        public int ManufacId { get; set; }
        [NotMapped]
        public bool SelectedYN { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public ICollection<Part> Part { get; set; }
    }
}
