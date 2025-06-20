using Microsoft.AspNetCore.Mvc;
using DesignPatternsDemo.Adapter;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdapterController : ControllerBase
    {
        [HttpGet("demo")]
        public IActionResult Demo()
        {
            var sensor = new FahrenheitSensor();
            ITemperatureSensor adapter = new TemperatureAdapter(sensor);
            var celsius = adapter.GetTemperatureCelsius();
            return Ok(new { Message = "Adapter pattern demo", Celsius = celsius });
        }
    }
}
