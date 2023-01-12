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
    public class CouponManager : ICouponService
    {
        ICouponDal _couponDal;

        public CouponManager(ICouponDal couponDal)
        {
            _couponDal = couponDal;
        }

        public void CouponAdd(Coupon coupon)
        {
            _couponDal.Insert(coupon);
        }

        public void CouponDelete(Coupon coupon)
        {
            _couponDal.Delete(coupon);
        }

        public void CouponUpdate(Coupon coupon)
        {
            _couponDal.Update(coupon);
        }

        public Coupon GetById(int id)
        {
            return _couponDal.Get(x => x.CouponId == id);
        }

        public List<Coupon> GetList()
        {
            return _couponDal.List();
        }
    }
}
