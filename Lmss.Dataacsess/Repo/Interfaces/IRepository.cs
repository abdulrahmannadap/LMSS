        using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lmss.Dataacsess.Data.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Edit(int id);
        void Save();
      
        T Get(int Id);
        T Get(Expression<Func<T, bool>> filter);
        IEnumerable<T> GetAll(int id);

        


    }
}
