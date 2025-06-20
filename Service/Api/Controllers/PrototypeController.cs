using Microsoft.AspNetCore.Mvc;
using DesignPatternsDemo.Prototype;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PrototypeController : ControllerBase
    {
        /// <summary>
        /// Demonstrates the Prototype pattern with a shallow copy example.
        /// </summary>
        [HttpGet("clone")]
        public IActionResult Clone([FromQuery] string content)
        {
            var original = new Document(content ?? "Sample");
            var clone = original.Clone();
            return Ok(new
            {
                Pattern = "Prototype",
                Original = original.Content,
                Clone = clone.Content,
                Description = "Creates new objects by copying an existing object, known as the prototype."
            });
        }
    }
}
