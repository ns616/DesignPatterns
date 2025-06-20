using Microsoft.AspNetCore.Mvc;
using DesignPatternsDemo.Interpreter;
using System.Collections.Generic;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InterpreterController : ControllerBase
    {
        /// <summary>
        /// Demonstrates the Interpreter pattern with a simple expression evaluation.
        /// </summary>
        [HttpGet("evaluate")]
        public IActionResult Evaluate([FromQuery] int x = 5, [FromQuery] int y = 3)
        {
            var context = new Dictionary<string, int> { { "x", x }, { "y", y } };
            var expression = new AddExpression(new VariableExpression("x"), new VariableExpression("y"));
            var result = expression.Interpret(context);
            return Ok(new
            {
                Pattern = "Interpreter",
                Expression = $"{x} + {y}",
                Result = result,
                Description = "Given a language, defines a representation for its grammar and an interpreter."
            });
        }
    }
}
