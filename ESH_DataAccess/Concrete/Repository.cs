using ESH_DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ESH_DataAccess.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        DefaultConnection c = new DefaultConnection();
        DbSet<T> _object;
        public Repository()
        {
            _object = c.Set<T>();
        }
        public int Delete(T p)
        {
            _object.Remove(p);
            return c.SaveChanges();
        }
        public T Find(Expression<Func<T, bool>> where)
        {
            return _object.FirstOrDefault(where);
        }
        public T GetByID(int id)
        {
            return _object.Find(id);
        }
        public int Insert(T p)
        {
            _object.Add(p);
            return c.SaveChanges();
        }
        public List<T> List()
        {
            return _object.ToList();
        }
        public IQueryable<T> Queryable()
        {
            return _object.AsQueryable();
        }
        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }
        public List<T> ListSearch(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }
        public int Update(T p)
        {
            return c.SaveChanges();
        }
        public bool Any(Expression<Func<T, bool>> expr)
        {
            return _object.Any(expr);
        }
    }
}
