using Microsoft.AspNetCore.Mvc;
using DesignPatternsDemo.ChainOfResponsibility;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChainOfResponsibilityController : ControllerBase
    {
        /// <summary>
        /// Demonstrates the Chain of Responsibility pattern with email and phone handlers.
        /// </summary>
        [HttpGet("handle")]
        public IActionResult Handle([FromQuery] string request)
        {
            var emailHandler = new EmailHandler();
            var phoneHandler = new PhoneHandler();
            emailHandler.SetNext(phoneHandler);

            var result = emailHandler.Handle(request ?? "email or phone");
            return Ok(new
            {
                Pattern = "Chain of Responsibility",
                Request = request,
                Result = result,
                Description = "Passes the request through a chain of handlers until one handles it."
            });
        }
    }
}
