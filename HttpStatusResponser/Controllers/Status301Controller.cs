using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HttpStatusResponser.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Status301Controller : ControllerBase
    {
        private readonly ILogger<Status301Controller> _logger;

        public Status301Controller(ILogger<Status301Controller> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return new RedirectResult("/status200", true);
        }

        [HttpGet("sleepms")]
        public IActionResult GetWithSleep(int sleepms)
        {
            Thread.Sleep(sleepms);
            return new RedirectResult("/status200", true);
        }
    }
}