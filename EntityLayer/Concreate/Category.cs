using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [StringLength(20)]
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }

        public ICollection<SubCategory> SubCategories { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
