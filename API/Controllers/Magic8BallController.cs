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
    public class Magic8BallController : ControllerBase
    {
        private readonly Magic8BallService _magicBall;
        public Magic8BallController(Magic8BallService magicball)
        {
            _magicBall = magicball;
        }
        [HttpGet("/AskAQuestion")]
        public string Magic8Ball(string question)
        {
            return _magicBall.Magic8Ball(question);
        }
    }
}