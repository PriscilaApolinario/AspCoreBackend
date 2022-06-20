using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace PrimeiroBackend.Controllers
{
    [ApiController]
    [Route("experimentos")]
    public class MyController : ControllerBase
    {
    

        private readonly ILogger<MyController> _logger;

        public MyController(ILogger<MyController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "Meu primeiro metodo get";
        }

        [HttpPost]
        public string Post([FromBody] JsonElement animal)
        {
            return animal.GetRawText();
        }
    }
}
