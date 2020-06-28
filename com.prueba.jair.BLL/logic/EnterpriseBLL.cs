﻿using com.prueba.jair.Core.interfaces;
using com.prueba.jair.Core.models;
using com.prueba.jair.DAL.context;
using com.prueba.jair.DAL.Repository;
using System;
using System.Linq;
using System.Net;

namespace com.prueba.jair.BLL.logic
{
    public class EnterpriseBLL : IBussinessLogic
    {
        protected EnterpriseRepository repo;
        protected ResponseModel response;
        protected MessageListModel messageList;

        public EnterpriseBLL(ApiDbContext context)
        {
            repo = new EnterpriseRepository(context);
            response = new ResponseModel();
            messageList = new MessageListModel();
        }

        public ResponseModel GetAll()
        {
            try
            {
                var message = new MessageModel();

                var list = repo.GetAll();

                if (list.Count > 0)
                {
                    response.Data = list;
                    message = messageList.ErrorList.Where(x => x.Id == 1).FirstOrDefault();
                }
                else
                {
                    message = messageList.ErrorList.Where(x => x.Id == 2).FirstOrDefault();
                }

                response.Status = message.Status;
                response.Message = message.Description;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Status = HttpStatusCode.InternalServerError;
            }

            return response;
        }

        public ResponseModel GetById(int id = 0)
        {
            var message = new MessageModel();

            try
            {
                var obj = repo.GetById(id);
                if (obj != null)
                {
                    response.Data = obj;
                    message = messageList.ErrorList.Where(x => x.Id == 1).FirstOrDefault();
                }
                else
                {
                    message = messageList.ErrorList.Where(x => x.Id == 2).FirstOrDefault();
                }

                response.Status = message.Status;
                response.Message = message.Description;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Status = HttpStatusCode.InternalServerError;
            }

            return response;
        }

        public ResponseModel GetByNit(decimal nit = 0)
        {
            var message = new MessageModel();

            try
            {
                var obj = repo.GetByNit(nit);

                if (obj != null)
                {
                    response.Data = obj;
                    message = messageList.ErrorList.Where(x => x.Id == 1).FirstOrDefault();
                }
                else
                {
                    message = messageList.ErrorList.Where(x => x.Id == 2).FirstOrDefault();
                }

                response.Status = message.Status;
                response.Message = message.Description;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Status = HttpStatusCode.InternalServerError;
            }

            return response;
        }
    }
}
