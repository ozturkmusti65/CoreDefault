using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreDefult.DAL.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert (T item);
        void Update (T item);
        void Delete (T item);
        List<T> GetAll ();
        T GetById (int id);
        List<T> GetListAll ();
        List<T> GetListAll(Expression<Func<T,bool>> filter);
    }
}
