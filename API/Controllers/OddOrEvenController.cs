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
    public class OddOrEvenController : ControllerBase
    {
        private readonly OddOrEvenService _oddOrEven;
        public OddOrEvenController(OddOrEvenService oddOrEven)
        {
            _oddOrEven = oddOrEven;
        }
        [HttpGet("Number/{number}")]
        public string OddOrEven(int number)
        {
            return _oddOrEven.OddOrEven(number);
        }
    }
}