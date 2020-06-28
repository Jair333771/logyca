using com.prueba.jair.BLL.logic;
using com.prueba.jair.Core.interfaces;
using com.prueba.jair.DAL.context;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Serialization;

namespace com.prueba.jair.SVC.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    [DataContract]
    public class EnterpriseController : ControllerBase
    {
        protected EnterpriseBLL enterpriseBll;

        public EnterpriseController(ApiDbContext context)
        {
            enterpriseBll = new EnterpriseBLL(context);
        }

        [HttpGet]
        public IActionResult GetEnterprise()
        {
            var response = enterpriseBll.GetAll();
            return StatusCode((int)response.Status, response);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var response = enterpriseBll.GetById(id);
            return StatusCode((int)response.Status, response);
        }

        [Route("bynit/{nit}")]
        [HttpGet]
        public IActionResult GetByNit(long nit)
        {
            var response = enterpriseBll.GetByNit(nit);
            return StatusCode((int)response.Status, response);
        }
    }
}