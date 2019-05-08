using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TnNext.Web.Controllers
{
    [Route("api/hello")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Hello World.";
        }
    }
}
