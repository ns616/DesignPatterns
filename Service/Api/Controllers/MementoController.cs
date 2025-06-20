using Microsoft.AspNetCore.Mvc;
using DesignPatternsDemo.Memento;
using System.IO;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MementoController : ControllerBase
    {
        /// <summary>
        /// Demonstrates the Memento pattern with a text editor example.
        /// </summary>
        [HttpGet("editor")]
        public IActionResult Editor([FromQuery] string text)
        {
            var originator = new Originator();
            originator.State = text ?? "Hello";
            var memento = originator.Save();
            originator.State = originator.State + " World";
            originator.Restore(memento);
            return Ok(new
            {
                Pattern = "Memento",
                State = originator.State,
                Description = "Captures and restores an object's internal state."
            });
        }
    }
}
