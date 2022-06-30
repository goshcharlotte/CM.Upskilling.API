using System;
using Microsoft.AspNetCore.Mvc;

namespace NBS.Practice.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        public HealthController()
        {
        }

        [HttpGet]
        [Route("ping")]
        public bool Ping()
        {
            return true;
            //return Ok(true);
        }

        [HttpGet]
        [Route("echo")]
        public string Echo(string str)
        {
            return str;
            //return Ok(str);
        }
    }
}

