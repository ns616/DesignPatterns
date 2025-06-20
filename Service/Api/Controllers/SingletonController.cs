using Microsoft.AspNetCore.Mvc;
using DesignPatternsDemo.Singleton;
using Microsoft.Extensions.Logging;

namespace DesignPatternsDemo.Api.Controllers
{
    /// <summary>
    /// Controller to demonstrate Singleton pattern via Logger.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SingletonController : ControllerBase
    {
        [HttpGet("log")]
        public IActionResult LogMessage([FromQuery] string message)
        {
            Logger.Instance.Log(message);
            var response = new
            {
                ResponseData = $"Logged message: {message}",
                Info = new
                {
                    Pattern = "Singleton",
                    Description = "Logger is a singleton. Only one instance is used throughout the app.",
                    Example = "Logger.Instance.Log(message)"
                }
            };
            return Ok(response);
        }
    }
}
