using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace APITesting.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private readonly IProvideTheName _nameProvider;

        public HelloWorldController(IProvideTheName nameProvider)
        {
            _nameProvider = nameProvider;
        }

        [HttpGet]
        public string Get()
        {
            return "Hello " + _nameProvider.GimmeTheName();
        }
    }
}
