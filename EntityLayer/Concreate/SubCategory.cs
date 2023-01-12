using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class SubCategory
    {
        [Key]
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public bool SubCategoryStatus { get; set; }

        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
