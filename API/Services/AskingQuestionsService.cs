using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class AskingQuestionsService
    {
        public string TwoQuestions(string name, string time)
        {
            return $"Your name is {name} and you woke up at {time}!";
        }
    }
}