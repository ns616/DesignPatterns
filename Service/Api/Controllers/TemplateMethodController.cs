using Microsoft.AspNetCore.Mvc;
using DesignPatternsDemo.TemplateMethod;
using System.IO;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TemplateMethodController : ControllerBase
    {
        [HttpGet("beverage")]
        public IActionResult Beverage([FromQuery] string type)
        {
            Beverage beverage = type?.ToLower() == "tea" ? new Tea() : new Coffee();
            using var sw = new StringWriter();
            Console.SetOut(sw);
            beverage.PrepareRecipe();
            var output = sw.ToString();
            return Ok(new { Pattern = "Template Method", Beverage = type ?? "Coffee", Output = output });
        }
    }
}
