using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pattern.UnitOfWork;
using System.Linq;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UnitOfWorkController : ControllerBase
    {
        private readonly ILogger<UnitOfWorkController> _logger;

        public UnitOfWorkController(ILogger<UnitOfWorkController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Demonstrates the Unit of Work pattern with in-memory customer operations.
        /// </summary>
        [HttpGet("demo")]
        public IActionResult Demo()
        {
            var unitOfWork = new UnitOfWork();
            _logger.LogInformation("Queuing customer operations...");
            unitOfWork.Customers.Add(new Customer { Id = 1, Name = "Alice" });
            unitOfWork.Customers.Add(new Customer { Id = 2, Name = "Bob" });
            unitOfWork.Customers.Remove(new Customer { Id = 1, Name = "Alice" });

            var beforeCommit = unitOfWork.Customers.GetAll().Select(c => c.Name).ToList();
            _logger.LogInformation("Before commit: {Customers}", string.Join(", ", beforeCommit));

            unitOfWork.Commit();
            var afterCommit = unitOfWork.Customers.GetAll().Select(c => c.Name).ToList();
            _logger.LogInformation("After commit: {Customers}", string.Join(", ", afterCommit));

            return Ok(new
            {
                Message = "Unit of Work demo completed.",
                BeforeCommit = beforeCommit,
                AfterCommit = afterCommit
            });
        }
    }
}
