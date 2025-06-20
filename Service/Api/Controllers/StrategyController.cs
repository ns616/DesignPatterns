using Microsoft.AspNetCore.Mvc;
using DesignPatternsDemo.Strategy;
using System;

namespace DesignPatternsDemo.Api.Controllers
{
    /// <summary>
    /// Controller to demonstrate Strategy pattern via PaymentContext.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class StrategyController : ControllerBase
    {
        [HttpGet("pay")]
        public IActionResult Pay([FromQuery] string method, [FromQuery] decimal amount)
        {
            IPaymentStrategy strategy = method?.ToLower() switch
            {
                "creditcard" => new CreditCardPayment(),
                "paypal" => new PaypalPayment(),
                _ => null
            };
            if (strategy == null)
                return BadRequest(new { Error = "Unknown payment method" });
            var context = new PaymentContext(strategy);
            context.Pay(amount);
            var response = new
            {
                ResponseData = $"Paid {amount:C} using {method}",
                Info = new
                {
                    Pattern = "Strategy",
                    Description = "PaymentContext selects payment strategy at runtime.",
                    Example = "context.SetStrategy(strategy); context.Pay(amount);"
                }
            };
            return Ok(response);
        }
    }
}
