using Microsoft.AspNetCore.Mvc;
using DesignPatternsDemo.Observer;
using System.Collections.Generic;

namespace DesignPatternsDemo.Api.Controllers
{
    /// <summary>
    /// Controller to demonstrate Observer pattern via NewsAgency.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ObserverController : ControllerBase
    {
        [HttpGet("news")]
        public IActionResult PublishNews([FromQuery] string headline)
        {
            var agency = new NewsAgency();
            var alice = new NewsSubscriber("Alice");
            var bob = new NewsSubscriber("Bob");
            agency.Subscribe(alice);
            agency.Subscribe(bob);
            agency.PublishNews(headline);
            var response = new
            {
                ResponseData = new List<object>
                {
                    new { Subscriber = alice.Name, Received = alice.ReceivedNews },
                    new { Subscriber = bob.Name, Received = bob.ReceivedNews }
                },
                Info = new
                {
                    Pattern = "Observer",
                    Description = "NewsAgency notifies all subscribers when news is published.",
                    Example = "agency.Subscribe(sub); agency.PublishNews(headline);"
                }
            };
            return Ok(response);
        }
    }
}
