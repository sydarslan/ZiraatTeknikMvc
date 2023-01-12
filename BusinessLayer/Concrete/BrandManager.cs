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
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void BrandAdd(Brand brand)
        {
            _brandDal.Insert(brand);
        }

        public void BrandDelete(Brand brand)
        {
            _brandDal.Delete(brand);
        }

        public void BrandUpdate(Brand brand)
        {
            _brandDal.Update(brand);
        }

        public Brand GetById(int id)
        {
            return _brandDal.Get(x => x.BrandId == id);
        }

        public List<Brand> GetList()
        {
            return _brandDal.List();
        }
    }
}
