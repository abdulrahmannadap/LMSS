using Lmss.Dataacsess.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Lmss.Dataacsess.Data.Implimentaions
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

       

        public void Edit(T entity)
        {
            _dbSet.Update(entity);  
        }

        public T Get(int id)
        {
            return _dbSet.Find(id);
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _dbSet.SingleOrDefault(filter);
        }

        public IEnumerable<T> GetAll(int id)
        {
            yield return _dbSet.Find(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
