using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project1.Data;
using Project1.Data.Models;
using Project1.Services.TestService;
using Project1.Services.UtilizatorService;

namespace Project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatabaseController : ControllerBase
    {
        private readonly IUtilizatorService _utilizatorService;

        public DatabaseController(IUtilizatorService utilizatorService)
        {
            _utilizatorService = utilizatorService;
        }

        [HttpGet("allUtilizatori")]
        public async Task<IActionResult> GetUtilizatori()
        {
            return Ok(await _utilizatorService.GetAll());
        }

        [HttpPost("createUtilizator")]
        public async Task<IActionResult> CreateUtilizator([FromBody] Utilizator utilizator)
        {
            await _utilizatorService.Create(utilizator);
            return Ok();
        }

        [HttpPatch("updateUtilizator")]
        public async Task<IActionResult> UpdateUtilizator([FromBody] Utilizator utilizator)
        {
            await _utilizatorService.Update(utilizator);
            return Ok();
        }

        [HttpDelete("delete/${id}")]
        public IActionResult DeleteUtilizator(Guid id)
        {
            _utilizatorService.Delete(id);
            return Ok();
        }
    }
}

