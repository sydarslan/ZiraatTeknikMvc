using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class UserDistrict
    {
        [Key]
        public int DistrictId { get; set; }
        public string DistrictName { get; set;}
        public int UserProvinceId { get; set; }
        public virtual UserProvince UserProvince { get; set; }

        public ICollection<User> Users  { get; set; }


    }
}
