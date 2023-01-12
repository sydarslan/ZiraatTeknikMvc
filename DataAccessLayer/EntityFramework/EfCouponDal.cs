using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCouponDal : GenericRepository<Coupon>, ICouponDal
    {
    }
}
