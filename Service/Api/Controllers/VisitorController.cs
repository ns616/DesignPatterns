using Microsoft.AspNetCore.Mvc;
using DesignPatternsDemo.Visitor;
using System.IO;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VisitorController : ControllerBase
    {
        [HttpGet("items")]
        public IActionResult Items()
        {
            var book = new Book("Design Patterns");
            var pen = new Pen("Blue");
            var visitor = new DisplayVisitor();
            using var sw = new StringWriter();
            Console.SetOut(sw);
            book.Accept(visitor);
            pen.Accept(visitor);
            var output = sw.ToString();
            return Ok(new { Pattern = "Visitor", Output = output });
        }
    }
}
