using com.prueba.jair.Core.interfaces;
using com.prueba.jair.DAL.context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace com.prueba.jair.DAL.Repository
{
    public class AppRepository<T> : IRepository<T> where T : class
    {
        protected ApiDbContext context;
        protected readonly DbSet<T> table;

        public AppRepository(ApiDbContext context)
        {
            this.context = context;
            table = this.context.Set<T>();
        }

        public List<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(int id)
        {
            return table.Find(id);
        }

        public int Add(T obj)
        {
            table.Add(obj);
            return context.SaveChanges();
        }

        public int Update(T obj)
        {
            table.Update(obj);
            return context.SaveChanges();
        }

        public int Delete(object id)
        {
            T obj = table.Find(id);
            table.Remove(obj);
            return context.SaveChanges();
        }
    }
}
