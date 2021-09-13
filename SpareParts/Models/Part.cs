using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpareParts.Models
{
    public class Part
    {
        public  int Id { get; set; }
        public string SerialNr { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public string ManufacturerName { get; set; }
        public decimal Price { get; set; }

        public bool IsActive { get; set; }
    }
}
