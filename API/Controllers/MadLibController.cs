using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Services;
using Microsoft.AspNetCore.Mvc;
using API.Models;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MadLibController : ControllerBase
    {
        private readonly MadLibService _madLib;
        public MadLibController(MadLibService madLib)
        {
            _madLib = madLib;
        }

        [HttpPost("/story")]
        public string MadLib(MabLib story)
        {
            return _madLib.MadLib(story);
        }
    }
}