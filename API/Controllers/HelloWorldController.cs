using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloWorldController : ControllerBase
    {   
        private readonly HelloWorldService _HelloWorld;
        public HelloWorldController(HelloWorldService helloWorld)  
        {
            _HelloWorld = helloWorld;
        }

        [HttpGet("Hello/{user}")]
        public string HelloUser(string user)
        {
            return _HelloWorld.HelloWorld(user);
        }
        
    }
}