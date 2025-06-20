using Microsoft.AspNetCore.Mvc;
using DesignPatternsDemo.Command;
using System.IO;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommandController : ControllerBase
    {
        /// <summary>
        /// Demonstrates the Command pattern with a simple light on/off example.
        /// </summary>
        [HttpGet("light")]
        public IActionResult Light([FromQuery] bool turnOn)
        {
            var light = new Light();
            ICommand command = turnOn ? new TurnOnCommand(light) : new TurnOffCommand(light);
            var remote = new RemoteControl();
            remote.SetCommand(command);
            using var sw = new StringWriter();
            Console.SetOut(sw);
            remote.PressButton();
            var output = sw.ToString();
            return Ok(new
            {
                Pattern = "Command",
                Action = turnOn ? "Turn On" : "Turn Off",
                Output = output,
                Description = "Encapsulates a request as an object, allowing parameterization and queuing."
            });
        }
    }
}
