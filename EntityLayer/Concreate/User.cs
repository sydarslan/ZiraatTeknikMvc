using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool UserStatus { get; set; }
        public DateTime UserDate { get; set; }
        public string Address { get; set; }
        public int UserProvinceId { get; set; }
        public virtual UserProvince UserProvince { get; set; }

        public int UserDistrictId { get; set; }
        public virtual UserDistrict UserDistrict { get; set; }

        public int UserRoleId { get; set; }
        public virtual UserRole UserRole { get; set; }
        public ICollection<Coupon> Coupons { get; set; }

    }
}
