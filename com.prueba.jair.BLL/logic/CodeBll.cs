using com.prueba.jair.Core.interfaces;
using com.prueba.jair.Core.models;
using com.prueba.jair.DAL.context;
using com.prueba.jair.DAL.entities;
using com.prueba.jair.DAL.Repository;
using System;
using System.Linq;

namespace com.prueba.jair.BLL.logic
{
    public class CodeBll : IBussinessLogic    
    {
        protected IRepository<Code> appRepository;
        protected ResponseModel response;
        protected MessageListModel messageList;

        public CodeBll(ApiDbContext context)
        {
            appRepository = new AppRepository<Code>(context);
            response = new ResponseModel();
            messageList = new MessageListModel();
        }

        public ResponseModel GetAll()
        {
            try
            {
                var message = new MessageModel();

                var list = appRepository.GetAll();

                if (list.Count > 0)
                {
                    response.Data = list;
                    message = messageList.ErrorList
                        .Where(x => x.Id == 1)
                        .FirstOrDefault();
                }
                else
                {
                    message = messageList.ErrorList
                        .Where(x => x.Id == 2)
                        .FirstOrDefault();
                }

                response.Status = message.Status;
                response.Message = message.Description;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Status = messageList.ErrorList.Where(x => x.Id == 4)
                    .FirstOrDefault().Status;
            }

            return response;
        }

        public ResponseModel GetById(int id = 0)
        {
            var message = new MessageModel();

            try
            {
                var obj = appRepository.GetById(id);
                if (obj != null)
                {
                    response.Data = obj;
                    message = messageList.ErrorList
                        .Where(x => x.Id == 1)
                        .FirstOrDefault();
                }
                else
                {
                    message = messageList.ErrorList
                        .Where(x => x.Id == 2)
                        .FirstOrDefault();
                }

                response.Status = message.Status;
                response.Message = message.Description;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Status = messageList.ErrorList.Where(x => x.Id == 4)
                    .FirstOrDefault().Status;
            }

            return response;
        }
    }
}
