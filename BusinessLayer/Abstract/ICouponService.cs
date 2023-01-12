using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICouponService
    {
        List<Coupon> GetList();
        void CouponAdd(Coupon coupon);
        Coupon GetById(int id);
        void CouponDelete(Coupon coupon);
        void CouponUpdate(Coupon coupon);
    }
}
