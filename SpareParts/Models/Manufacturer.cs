using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpareParts.Models
{
    public class Manufacturer
    {
        public int ManufacId { get; set; }
        public string Name { get; set; }
        public bool SelectedYN { get; set; }
    }
}
