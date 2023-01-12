using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public decimal Price { get; set; }
        public string ProductDescription { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int SubCategoryId { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        public bool ProductStatus { get; set; }
        public DateTime ProductDate  { get; set; }

        public ICollection<Stock> Stocks { get; set; }



    }
}
