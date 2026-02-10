using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class HelloWorldService
    {
        public string HelloWorld(string user)
        {
            return $"Hello, {user}!";
        }
    }
}