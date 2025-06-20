using Microsoft.AspNetCore.Mvc;
using DesignPatternsDemo.Mediator;
using System.IO;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MediatorController : ControllerBase
    {
        /// <summary>
        /// Demonstrates the Mediator pattern with a chatroom example.
        /// </summary>
        [HttpGet("chat")]
        public IActionResult Chat([FromQuery] string user, [FromQuery] string message)
        {
            var chatroom = new ChatRoom();
            var sender = new User(user ?? "Alice", chatroom);
            using var sw = new StringWriter();
            Console.SetOut(sw);
            sender.Send(message ?? "Hello!");
            var output = sw.ToString();
            return Ok(new
            {
                Pattern = "Mediator",
                User = user ?? "Alice",
                Message = message ?? "Hello!",
                Output = output,
                Description = "Defines an object that encapsulates how a set of objects interact."
            });
        }
    }
}
