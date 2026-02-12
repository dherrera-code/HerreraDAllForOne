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
    public class GreaterOrLessController : ControllerBase
    {
        private readonly GreaterOrLessService _greaterOrLess;
        public GreaterOrLessController(GreaterOrLessService greaterOrLess)
        {
            _greaterOrLess = greaterOrLess;
        }

        [HttpGet("/{num1}/{num2}")]
        public string GetResult(int num1, int num2)
        {
            return _greaterOrLess.GreaterOrLess(num1,num2);
        }
    }
}