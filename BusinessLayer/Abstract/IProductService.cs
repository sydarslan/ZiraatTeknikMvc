using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductService
    {
        List<Product> GetList();
        void ProductAdd(Product product);
        Product GetById(int id);
        void ProductDelete(Product product);
        void ProductUpdate(Product product);
    }
}
