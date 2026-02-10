using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class AddingTwoNumberService
    {
        public string AddTwoNumbers(int num1, int num2)
        {
            return $"The Sum of {num1} and {num2} is {num1+num2}!";
        }
    }
}