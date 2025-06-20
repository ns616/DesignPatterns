using Microsoft.AspNetCore.Mvc;
using DesignPatternsDemo.Proxy;
using System.IO;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProxyController : ControllerBase
    {
        [HttpGet("image")]
        public IActionResult Image([FromQuery] string filename)
        {
            IImage image = new ProxyImage(filename ?? "test.jpg");
            using var sw = new StringWriter();
            Console.SetOut(sw);
            image.Display();
            var output = sw.ToString();
            return Ok(new { Pattern = "Proxy", Filename = filename ?? "test.jpg", Output = output });
        }
    }
}
