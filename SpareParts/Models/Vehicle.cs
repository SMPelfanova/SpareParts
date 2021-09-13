using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpareParts.Models
{
    public class Vehicle
    {

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Engine { get; set; }
        public string Fuel { get; set; }
    }
}
