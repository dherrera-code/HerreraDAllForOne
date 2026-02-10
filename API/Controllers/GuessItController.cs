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
    public class GuessItController : ControllerBase
    {
        private readonly GuessItService _guessIt;
        public GuessItController(GuessItService guessIt)
        {
            _guessIt = guessIt;
        }

        [HttpGet("/easy/{guess}")]
        public string GuessItEasy(int guess)
        {
            return _guessIt.StartGameEasy(guess);
        }

        [HttpGet("/medium/{guess}")]
        public string GuessItMedium(int guess)
        {
            return _guessIt.StartGameMedium(guess);
        }
        [HttpGet("/hard/{guess}")]
        public string GuessItHard(int guess)
        {
            return _guessIt.StartGameHard(guess);
        }
    }
}