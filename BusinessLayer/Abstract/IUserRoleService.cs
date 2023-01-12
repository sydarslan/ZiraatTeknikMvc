using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserRoleService
    {
        List<UserRole> GetList();
        void UserRoleAdd(UserRole userRole);
        UserRole GetById(int id);
        void UserRoleDelete(UserRole userRole);
        void UserRoleUpdate(UserRole userRole);
    }
}
