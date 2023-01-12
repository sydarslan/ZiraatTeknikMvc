using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserProvinceManager : IUserProvinceService
    {
        IUserProvinceDal _provinceDal;

        public UserProvinceManager(IUserProvinceDal provinceDal)
        {
            _provinceDal = provinceDal;
        }

        public UserProvince GetById(int id)
        {
            return _provinceDal.Get(x => x.ProvinceId == id);
        }

        public List<UserProvince> GetList()
        {
            return _provinceDal.List();
        }
    }
}
