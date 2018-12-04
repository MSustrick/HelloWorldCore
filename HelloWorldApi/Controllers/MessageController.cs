using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        // GET api/message
        [HttpGet]
        public ActionResult<string> Get()
        {
            return  "Hello World!";
        }

        
    }
}
