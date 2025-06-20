using Microsoft.AspNetCore.Mvc;
using DesignPatternsDemo.Builder;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BuilderController : ControllerBase
    {
        [HttpGet("demo")]
        public IActionResult Demo()
        {
            var director = new MealDirector();
            var builder = new VegMealBuilder();
            var meal = director.Construct(builder);
            return Ok(new { Pattern = "Builder", Meal = meal.ToString() });
        }
    }
}
