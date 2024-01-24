using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project1.Services.TestService;
using Project1.Data.Models;


namespace Project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ITestService _testService;

        public TestController(ITestService testService)
        {
            _testService = testService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetTests()
        {
            return Ok(await _testService.GetAll());
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateTest([FromBody] TestModel test)
        {
            await _testService.Create(test);
            return Ok();
        }

        [HttpPatch("update")]
        public async Task<IActionResult> UpdateTest([FromBody] TestModel test)
        {
            await _testService.Update(test);
            return Ok();
        }

        [HttpDelete("delete/${id}")]
        public IActionResult DeleteTest(Guid id)
        {
            _testService.Delete(id);
            return Ok();
        }
    }
}
