using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class UserProvince
    {
        [Key]
        public int ProvinceId { get; set; }
        public string ProvinceName { get; set; }

        public ICollection<UserDistrict> UserDistricts { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
