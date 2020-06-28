using System.Net;

namespace com.prueba.jair.Core.models
{
    public class ResponseModel
    {
        public HttpStatusCode Status { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
