using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserProvinceService
    {
        List<UserProvince> GetList();
        UserProvince GetById(int id);
    
    }
}
