using com.prueba.jair.Core.models;

namespace com.prueba.jair.Core.interfaces
{
    public interface IBussinessLogic
    {
        public ResponseModel GetAll();
        public ResponseModel GetById(int id);
    }
}
