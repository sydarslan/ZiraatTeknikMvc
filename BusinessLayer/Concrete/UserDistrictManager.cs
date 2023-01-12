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
    public class UserDistrictManager : IUserDistrictService
    {
        IUserDistrictDal _districtDal;

        public UserDistrictManager(IUserDistrictDal districtDal)
        {
            _districtDal = districtDal;
        }

        public UserDistrict GetById(int id)
        {
            return _districtDal.Get(x => x.DistrictId == id);
        }

        public List<UserDistrict> GetList()
        {
            return _districtDal.List();
        }
    }
}
