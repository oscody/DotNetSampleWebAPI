
using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services_Interfaces;
using Services_Interfaces.Models;

namespace DotNetSampleWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;
        private readonly ITestService TestService;
        private readonly TestContext _context;

        public TestController(ILogger<TestController> logger, ITestService testService, TestContext context)
        {
            _logger = logger;
            this.TestService = testService;
            this._context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {

            var response = _context.GenericModel.FromSql($"select Name from Products").ToList();
            return Ok(response);
        }

        [HttpGet]
        public async Task<ActionResult<Product>> GetProducts()
        {
            var d = await TestService.GetProduct(1);
            return Ok(d);
        }


        public void TestSp() {


            var response = _context.GenericModel.FromSql($"select Name from Products").ToList();
            ///return Ok(response);

        }
    }
}