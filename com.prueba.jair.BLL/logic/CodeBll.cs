using com.prueba.jair.Core.interfaces;
using com.prueba.jair.Core.models;
using com.prueba.jair.DAL.context;
using com.prueba.jair.DAL.Repository;

namespace com.prueba.jair.BLL.logic
{
    public class CodeBll : AppBLL, IBussinessLogic
    {
        protected CodeRepository repo;      

        public CodeBll(ApiDbContext context)
        {
            repo = new CodeRepository(context);
        }

        public ResponseModel GetAll()
        {
            var message = new MessageModel();
            var list = repo.GetAll();
            SetObjectResponse(list, message);

            return response;
        }

        public ResponseModel GetById(int id)
        {
            var message = new MessageModel();
            var obj = repo.GetById(id);
            SetObjectResponse(obj, message);

            return response;
        }

        public ResponseModel GetAllByOwnerId(int id = 0)
        {
            var message = new MessageModel();
            var list = repo.GetAllByOwnerId(id);
            SetListResponse(list, message);

            return response;
        }

        public ResponseModel GetEnterpriseByCodeId(int id = 0)
        {
            var message = new MessageModel();

            var obj = repo.GetEnterpriseByCodeId(id);
            SetObjectResponse(obj, message);

            return response;
        }
    }
}
