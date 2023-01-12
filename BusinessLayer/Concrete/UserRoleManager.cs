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
    public class UserRoleManager : IUserRoleService
    {
        IUserRoleDal _roleDal;

        public UserRoleManager(IUserRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public UserRole GetById(int id)
        {
            return _roleDal.Get(x=>x.UserRoleId== id);
        }

        public List<UserRole> GetList()
        {
            return _roleDal.List();
        }

        public void UserRoleAdd(UserRole userRole)
        {
            _roleDal.Insert(userRole);
        }

        public void UserRoleDelete(UserRole userRole)
        {
            _roleDal.Delete(userRole);
        }

        public void UserRoleUpdate(UserRole userRole)
        {
            _roleDal.Update(userRole);
        }
    }
}
