using Microsoft.AspNetCore.Mvc;
using DesignPatternsDemo.State;
using System.IO;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StateController : ControllerBase
    {
        [HttpGet("switch")]
        public IActionResult SwitchDemo([FromQuery] int presses)
        {
            var sw = new Switch(new OffState());
            using var swriter = new StringWriter();
            Console.SetOut(swriter);
            for (int i = 0; i < (presses > 0 ? presses : 3); i++)
                sw.Press();
            var output = swriter.ToString();
            return Ok(new { Pattern = "State", Output = output });
        }
    }
}
