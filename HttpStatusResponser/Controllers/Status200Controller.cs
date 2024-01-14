using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HttpStatusResponser.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Status200Controller : ControllerBase
    {
        private readonly ILogger<Status200Controller> _logger;

        public Status200Controller(ILogger<Status200Controller> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet("sleepms")]
        public IActionResult GetWithSleep(int sleepms)
        {
            Thread.Sleep(sleepms);
            return Ok();
        }
    }
}