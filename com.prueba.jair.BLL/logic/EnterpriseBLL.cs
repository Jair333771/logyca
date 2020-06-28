using com.prueba.jair.Core.interfaces;
using com.prueba.jair.Core.models;
using com.prueba.jair.DAL.context;
using com.prueba.jair.DAL.Repository;

namespace com.prueba.jair.BLL.logic
{
    public class EnterpriseBLL : AppBLL, IBussinessLogic
    {
        protected EnterpriseRepository repo;

        public EnterpriseBLL(ApiDbContext context)
        {
            repo = new EnterpriseRepository(context);
        }

        public ResponseModel GetAll()
        {
            var message = new MessageModel();
            var list = repo.GetAll();
            SetListResponse(list, message);
            return response;
        }

        public ResponseModel GetById(int id = 0)
        {
            var message = new MessageModel();
            var obj = repo.GetById(id);
            SetObjectResponse(obj, message);
            return response;
        }

        public ResponseModel GetByNit(long nit = 0)
        {
            var message = new MessageModel();
            var obj = repo.GetByNit(nit);
            SetObjectResponse(obj, message);
            return response;
        }
    }
}
