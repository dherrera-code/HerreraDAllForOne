using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class GreaterOrLessService
    {
        public string GreaterOrLess(int num1, int num2)
        {
            if (num1 > num2)
                return $"{num1} is Greater than {num2} and {num2} is Less than {num1}!";
            else if (num1 < num2)
                return $"{num2} is Greater than {num1} and {num1} is Less than {num2}!";
            else return $"{num1} is equal to {num2}!";
        }
    }
}