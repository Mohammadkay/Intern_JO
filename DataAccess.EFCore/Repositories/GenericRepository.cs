using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EFCore.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public AppDbContext db;
        public GenericRepository(AppDbContext _db)
        {
            db= _db;
        }
        public void Add(T entity)
        {
            db.Set<T>().Add(entity);
        }

        public int Count()
        {
            return db.Set<T>().Count();
        }

        public void Delete(T entity)
        {
            db.Set<T>().Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
           db.Set<T>().Update(entity);
        }
    }
}
