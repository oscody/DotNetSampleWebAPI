
using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNetSampleWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;

        private readonly TestContext _context;

        public TestController(ILogger<TestController> logger, TestContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {

            var response = _context.GenericModel.FromSql($"select Name from Products").ToList();
            return Ok(response);
        }
    }
}