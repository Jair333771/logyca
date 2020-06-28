using System.Runtime.Serialization;
using com.prueba.jair.BLL.logic;
using com.prueba.jair.DAL.context;
using Microsoft.AspNetCore.Mvc;

namespace com.prueba.jair.SVC.Controllers
{

    [Route("/[controller]")]
    [ApiController]
    [DataContract]
    public class CodeController : ControllerBase
    {
        protected CodeBll codeBll;

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

        [Route("ownerid/{ownerid}")]
        [HttpGet]
        public IActionResult GetByOwnerId(int ownerid)
        {
            var response = codeBll.GetAllByOwnerId(ownerid);
            return StatusCode((int)response.Status, response);
        }

        [HttpGet("{id}")]
        public IActionResult GetEnterpriseByCodeId(int codeid)
        {
            var response = codeBll.GetById(codeid);
            return StatusCode((int)response.Status, response);
        }
    }
}