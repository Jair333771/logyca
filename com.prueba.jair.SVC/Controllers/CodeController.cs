using System.Runtime.Serialization;
using com.prueba.jair.BLL.logic;
using com.prueba.jair.Core.interfaces;
using com.prueba.jair.DAL.context;
using Microsoft.AspNetCore.Mvc;

namespace com.prueba.jair.SVC.Controllers
{

    [Route("/[controller]")]
    [ApiController]
    [DataContract]
    public class CodeController : ControllerBase
    {
        protected IBussinessLogic codeBll;

        public CodeController(ApiDbContext context)
        {
            codeBll = new CodeBll(context);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var response = codeBll.GetAll();
            return StatusCode((int)response.Status, response);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var response = codeBll.GetById(id);
            return StatusCode((int)response.Status, response);
        }
    }
}