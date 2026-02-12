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
    public class MadLibShortController : ControllerBase
    {
        private readonly MadLibShortService _madLibShort;
        public MadLibShortController(MadLibShortService madLibShort)
        {
            _madLibShort = madLibShort;
        }

        [HttpGet("{name}/{location}/{adjective}/{creature}/{mood}")]
        public string ShortStory (string name, string location, string adjective, string creature, string mood)
        {
            return _madLibShort.Story(name,location,adjective,creature,mood);
        }
    }
}