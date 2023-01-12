using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context c=new Context();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = c.Set<T>();
        }

        public void Delete(T param)
        {
            var deletedEntity = c.Entry(param);
            deletedEntity.State = EntityState.Deleted;
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> Filter)
        {
            return _object.SingleOrDefault(Filter);
        }

        public void Insert(T param)
        {
            var addedEntity = c.Entry(param);
            addedEntity.State = EntityState.Added;
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T param)
        {
            var updatedEntity = c.Entry(param);
            updatedEntity.State = EntityState.Modified;
            c.SaveChanges();
        }
    }
}
