using Microsoft.AspNetCore.Mvc;
using DesignPatternsDemo.Facade;
using System.IO;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FacadeController : ControllerBase
    {
        /// <summary>
        /// Demonstrates the Facade pattern with a home theater example.
        /// </summary>
        [HttpGet("home-theater")]
        public IActionResult HomeTheater()
        {
            var audio = new AudioSystem();
            var video = new VideoSystem();
            using var sw = new StringWriter();
            Console.SetOut(sw);
            audio.On();
            video.On();
            audio.Off();
            video.Off();
            var output = sw.ToString();
            return Ok(new
            {
                Pattern = "Facade",
                Output = output,
                Description = "Provides a unified interface to a set of interfaces in a subsystem."
            });
        }
    }
}
