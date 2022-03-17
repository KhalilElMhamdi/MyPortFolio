using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class GenericRepsitory<T> : IGenericRepository<T> where T : class
    {
        private readonly DataContext _dataContext;
        private DbSet<T> table = null;
        public GenericRepsitory(DataContext context)
        {
           _dataContext = context;
            table = _dataContext.Set<T>();


        }
        IEnumerable<T> IGenericRepository<T>.GetAll()
        {
           return  table.ToList();
        }
        void IGenericRepository<T>.Delete(int id)
        {
          
        }

        T IGenericRepository<T>.Get(int id)
        {
            throw new NotImplementedException();
        }

      

        void IGenericRepository<T>.Insert(T item)
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<T>.Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
