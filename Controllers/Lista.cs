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
    [Route("lista")]
    public class Lista : ControllerBase
    {
    
        private static readonly List<string> lista1 = new List<string>();

        private readonly ILogger<Lista> _logger;

        public Lista(ILogger<Lista> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<string> Get()
        {
           return Lista.lista1;
        }

        [HttpPost]
        public List<string> Post([FromBody] JsonElement json)
        {
            var dict = JsonSerializer.Deserialize<Dictionary<string, string>>(json.ToString());
            string texto = dict["texto"];
            Lista.lista1.Add(texto);
           
            return Lista.lista1;
        }
    }
}