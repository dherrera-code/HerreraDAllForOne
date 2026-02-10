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
    public class AskingQuestionsController : ControllerBase
    {
        private readonly AskingQuestionsService _askQuestion;

        public AskingQuestionsController(AskingQuestionsService askQuestions)
        {
            _askQuestion = askQuestions;
        }

        [HttpGet("EnterNameAndTime/{name}/{time}")]
        public string AskQuestion(string name, string time)
        {
            return _askQuestion.TwoQuestions(name,time);
        }
    }
}