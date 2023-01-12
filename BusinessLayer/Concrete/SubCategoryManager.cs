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
    public class SubCategoryManager : ISubCategoryService
    {
        ISubCategoryDal _subcategoryDal;

        public SubCategoryManager(ISubCategoryDal subcategoryDal)
        {
            _subcategoryDal = subcategoryDal;
        }

        public SubCategory GetById(int id)
        {
            return _subcategoryDal.Get(x => x.SubCategoryId == id);
        }

        public List<SubCategory> GetList()
        {
            return _subcategoryDal.List();
        }

        public void SubCategoryAdd(SubCategory subCategory)
        {
            _subcategoryDal.Insert(subCategory);
        }

        public void SubCategoryDelete(SubCategory subCategory)
        {
            _subcategoryDal.Delete(subCategory);
        }

        public void SubCategoryUpdate(SubCategory subCategory)
        {
            _subcategoryDal.Update(subCategory);
        }
    }
}
