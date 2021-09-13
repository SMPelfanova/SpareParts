using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Data.Models
{
    public class PartImage
    {
        public int Id { get; set; }
        public string ImageFileName { get; set; }
        public Part Part { get; set; }
    }
}
