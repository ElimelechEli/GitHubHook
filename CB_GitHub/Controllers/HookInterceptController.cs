using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using CB_GitHub.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CB_GitHub.Controllers
{
    [ApiController]
    [Route("/githubhook")]
    public class HookInterceptController : ControllerBase
    {
        private readonly ILogger<HookInterceptController> _logger;

        public HookInterceptController(ILogger<HookInterceptController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public object Post([FromHeader] Dictionary<string, string> header, [FromBody] object body)
        {
            
            Console.WriteLine(JsonSerializer.Serialize(body));
            return body;
        }
    }
}
