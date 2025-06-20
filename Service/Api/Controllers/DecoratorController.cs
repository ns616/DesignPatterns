using Microsoft.AspNetCore.Mvc;
using DesignPatternsDemo.Decorator;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DecoratorController : ControllerBase
    {
        /// <summary>
        /// Demonstrates the Decorator pattern with a coffee example.
        /// </summary>
        [HttpGet("coffee")]
        public IActionResult Coffee([FromQuery] bool withMilk)
        {
            IBeverage beverage = new Coffee();
            if (withMilk)
                beverage = new MilkDecorator(beverage);
            return Ok(new { Pattern = "Decorator", Description = beverage.GetDescription(), Cost = beverage.GetCost() });
        }
    }
}
