using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserDistrictService
    {
        List<UserDistrict> GetList();
        UserDistrict GetById(int id);
 
    }
}
