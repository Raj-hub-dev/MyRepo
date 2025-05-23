using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyWebapiapp_JWTAuth.Controllers
{
    [Authorize]
    public class CalculatorController : ApiController
    {
        [HttpGet]
        [Route("api/calc/add")]
        public IHttpActionResult Add(int a, int b)
        {
            return Ok(a + b);
        }
    }
}
