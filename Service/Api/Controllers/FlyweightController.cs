using Microsoft.AspNetCore.Mvc;
using DesignPatternsDemo.Flyweight;
using System.IO;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FlyweightController : ControllerBase
    {
        /// <summary>
        /// Demonstrates the Flyweight pattern with a tree factory example.
        /// </summary>
        [HttpGet("tree")]
        public IActionResult Tree([FromQuery] string type)
        {
            var factory = new TreeFactory();
            var treeType = factory.GetTreeType(type ?? "Oak");
            using var sw = new StringWriter();
            Console.SetOut(sw);
            treeType.Display(10, 20);
            var output = sw.ToString();
            return Ok(new
            {
                Pattern = "Flyweight",
                TreeType = type ?? "Oak",
                Output = output,
                Description = "Uses sharing to support large numbers of fine-grained objects efficiently."
            });
        }
    }
}
