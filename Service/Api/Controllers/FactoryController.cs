using Microsoft.AspNetCore.Mvc;
using DesignPatternsDemo.Factory;
using System;

namespace DesignPatternsDemo.Api.Controllers
{
    /// <summary>
    /// Controller to demonstrate Factory pattern via NotificationFactory.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class FactoryController : ControllerBase
    {
        [HttpGet("notify")]
        public IActionResult Notify([FromQuery] string type, [FromQuery] string message)
        {
            try
            {
                var factory = new NotificationFactory();
                var notification = factory.CreateNotification(type);
                notification.Send(message);
                var response = new
                {
                    ResponseData = $"{type} notification sent: {message}",
                    Info = new
                    {
                        Pattern = "Factory",
                        Description = "NotificationFactory creates notification objects based on type.",
                        Example = "factory.CreateNotification(type).Send(message)"
                    }
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Error = ex.Message });
            }
        }
    }
}
