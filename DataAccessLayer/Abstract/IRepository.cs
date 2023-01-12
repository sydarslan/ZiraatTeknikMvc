using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T> //tüm tablolar için tek tek interface tanımlama sorununu çözer 
    {
        List<T> List();
        void Insert(T param);
        void Delete(T param);
        void Update(T param);
        T Get(Expression<Func<T, bool>> Filter);
        List<T> List(Expression<Func<T, bool>> filter);
    }
}
