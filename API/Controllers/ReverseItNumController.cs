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
    public class ReverseItNumController : ControllerBase
    {
        private readonly ReverseItNumService _reverseNums;
        public ReverseItNumController(ReverseItNumService reverseNums)
        {
            _reverseNums = reverseNums;
        }

        [HttpGet("/numbersOnly/{numbers}")]
        public string ReverseNumbers(string numbers)
        {
            return _reverseNums.ReverseItNums(numbers);
        }
    }
}