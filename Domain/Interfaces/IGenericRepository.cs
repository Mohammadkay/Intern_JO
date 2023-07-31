using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        void Add(T entity);

        void Delete(T entity);

        T GetById(int id);

        void Update(T entity); 

        int Count();
    }
}
