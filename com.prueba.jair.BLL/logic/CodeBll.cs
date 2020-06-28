using com.prueba.jair.Core.interfaces;
using com.prueba.jair.Core.models;
using com.prueba.jair.DAL.context;
using com.prueba.jair.DAL.entities;
using com.prueba.jair.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace com.prueba.jair.BLL.logic
{
    public class CodeBll : IBussinessLogic
    {
        protected CodeRepository repo;
        protected ResponseModel response;
        protected MessageListModel messageList;

        public CodeBll(ApiDbContext context)
        {
            repo = new CodeRepository(context);
            response = new ResponseModel();
            messageList = new MessageListModel();
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
            SetObjectResponse(list, message);

            return response;
        }


        public ResponseModel GetEnterpriseByCodeId(int codeid = 0)
        {
            var message = new MessageModel();

            var obj = repo.GetEnterpriseByCodeId(codeid);
            SetObjectResponse(obj, message);

            return response;
        }

        public void SetObjectResponse(object obj, MessageModel message)
        {
            try
            {
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
        }

        public void SetListResponse(List<object> list, MessageModel message)
        {
            try
            {
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
        }
    }
}
