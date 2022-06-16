using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MeExtension.Service.Controllers
{
    [ApiController]
    public class PingController : ControllerBase
    {
        private readonly ILogger<PingController> _logger;

        public PingController(ILogger<PingController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/ping")]
        public IActionResult Ping()
        {
            _logger.LogInformation("Request to {endpoint}", "/ping");
            return Ok("pong");
        }
    }
}
