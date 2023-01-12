using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Coupon
    {
        [Key]
        public int CouponId { get; set; }
        public string CouponCode { get; set; }
        public decimal CouponPrice { get; set; }
        public bool CouponStatus { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
