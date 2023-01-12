using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetList();
        void BrandAdd(Brand brand);
        Brand GetById(int id);
        void BrandDelete(Brand brand);
        void BrandUpdate(Brand brand);
    }
}
