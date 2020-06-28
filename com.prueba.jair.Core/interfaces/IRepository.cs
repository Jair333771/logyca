using System.Collections.Generic;

namespace com.prueba.jair.Core.interfaces
{
    public interface IRepository<T> where T : class
    {
        public List<T> GetAll();

        public T GetById(int id);

        public int Add(T obj);

        public int Update(T obj);

        public int Delete(object id);
    }
}
