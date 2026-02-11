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
    public class AddingTwoNumberController : ControllerBase
    {
        private readonly AddingTwoNumberService _addTwoNums;
        public AddingTwoNumberController(AddingTwoNumberService addTwoNums)
        {
            _addTwoNums = addTwoNums;
        }
        //api/AddingTwoNumber/2/3
        [HttpGet("adding/{num1}/{num2}")]
        public string AddTwoNumbers(int num1, int num2)
        {
            return _addTwoNums.AddTwoNumbers(num1,num2);
        }
    }
}