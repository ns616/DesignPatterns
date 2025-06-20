using Microsoft.AspNetCore.Mvc;
using DesignPatternsDemo.Bridge;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BridgeController : ControllerBase
    {
        [HttpGet("demo")]
        public IActionResult Demo()
        {
            var vector = new VectorDrawing();
            var raster = new RasterDrawing();
            var circle1 = new Circle(0, 0, 5, vector);
            var circle2 = new Circle(10, 10, 3, raster);
            circle1.Draw();
            circle2.Draw();
            return Ok(new { Message = "Bridge pattern demo", Info = "See console output for drawing details." });
        }
    }
}
