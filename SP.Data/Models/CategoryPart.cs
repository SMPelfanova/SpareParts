using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Data.Models
{
    public class CategoryPart
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int PartId { get; set; }
        public Part Part { get; set; }
    }
}
