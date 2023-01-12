using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISubCategoryService
    {
        List<SubCategory> GetList();
        void SubCategoryAdd(SubCategory subCategory);
        SubCategory GetById(int id);
        void SubCategoryDelete(SubCategory subCategory);
        void SubCategoryUpdate(SubCategory subCategory);
    }
}
