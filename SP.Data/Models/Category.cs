using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Data.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public int? ParentCategoryId { get; set; }
        public string Name { get; set; }
        public string ImageFileName { get; set; }
        public virtual Category Parent { get; set; }
        public virtual HashSet<Category> Children { get; set; }
        public ICollection<CategoryPart> CategoryParts { get; set; }
        public ICollection<VehicleTypeCategory> VehicleTypeCategories { get; set; }

    }
}
