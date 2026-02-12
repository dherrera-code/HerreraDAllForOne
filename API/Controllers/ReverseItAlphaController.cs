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
    public class ReverseItAlphaController : ControllerBase
    {
        private readonly ReverseItAlphaService _reverseIt;
        public ReverseItAlphaController(ReverseItAlphaService reverseIt)
        {
            _reverseIt = reverseIt;
        }
        [HttpGet("{sequenceAlpha}")]
        public string ReverseItAlpha(string sequenceAlpha)
        {
            return _reverseIt.ReverseItAlpha(sequenceAlpha);
        }
    }
}