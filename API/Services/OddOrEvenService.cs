using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class OddOrEvenService
    {
        public string OddOrEven(int num)
        {
            // if(int.TryParse(num, out int number))
            if(num % 2 == 0)
                return $"{num} is an Even number!";
            else
            return $"{num} is an Odd number!";
            // return (num % 2 == 0) ? $"{num} is an Even number!" : $"{num} is an Odd number!";
        }
    }
}