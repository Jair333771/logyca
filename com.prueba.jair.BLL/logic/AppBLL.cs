using com.prueba.jair.Core.models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace com.prueba.jair.BLL.logic
{
    public class AppBLL
    {
        protected ResponseModel response;
        protected MessageListModel messageList;

        public AppBLL()
        {
            response = new ResponseModel();
            messageList = new MessageListModel();
        }

        public void SetObjectResponse<T>(T obj, MessageModel message)
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

        public void SetListResponse<T>(List<T> list, MessageModel message)
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
