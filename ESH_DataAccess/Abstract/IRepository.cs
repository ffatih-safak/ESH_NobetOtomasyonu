using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ESH_DataAccess.Abstract
{
    public interface IRepository<T>
    {
        List<T> List();
        IQueryable<T> Queryable();
        int Insert(T p);
        int Update(T p);
        int Delete(T p);
        T GetByID(int id);
        //İstedğiğmiz yerde search işlemi yapabilme imkanı tanıyor;
        List<T> List(Expression<Func<T, bool>> filter);
        T Find(Expression<Func<T, bool>> where);
        bool Any(Expression<Func<T, bool>> expr);
    }
}
