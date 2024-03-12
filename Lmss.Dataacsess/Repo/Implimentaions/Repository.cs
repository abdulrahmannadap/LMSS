using Lmss.Dataacsess.Data.Interfaces;
using Lmss.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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

        public void Edit(int id)
        {
            _dbSet.Find(id);
        }

        public T Get(int Id)
        {
            return _dbSet.Find(id);
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _dbSet.SingleOrDefault(filter);
        }

        public IEnumerable<T> GetAll(int id)
        {
            return _dbSet.GetAll(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
