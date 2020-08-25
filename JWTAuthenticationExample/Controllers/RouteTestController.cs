using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTAuthenticationExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[AllowAnonymous]
    public class RouteTestController : ControllerBase
    {
        [HttpGet("v1")]
        public IEnumerable<string> Get()
        {
            List<string> days = new List<string> { "Sunday", "Monday" };
            return days;
        }

        [HttpGet("v2")]
        public IEnumerable<string> Get2()
        {
            List<string> names = new List<string> { "Butul", "Banik" };
            return names;
        }

        [HttpGet("{id:int:min(3)}")]
        public string test1(int id)
        {
            return "ID= " + id;
        }
    }
}