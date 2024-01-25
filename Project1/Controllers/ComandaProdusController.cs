using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project1.Data.Models;
using Project1.Services.ComandaProdusService;
using Project1.Services.ProdusService;

namespace Project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComandaProdusController : ControllerBase
    {
        private readonly IComandaProdusService _comandaProdusService;

        public ComandaProdusController(IComandaProdusService comandaProdusService)
        {
            _comandaProdusService = comandaProdusService;
        }

        [HttpGet("allComandaProduse")]
        public async Task<IActionResult> GetComandaProduse()
        {
            return Ok(await _comandaProdusService.GetAll());
        }

        [HttpPost("createComandaProdus")]
        public async Task<IActionResult> CreateComandaProdus([FromBody] ComandaProdus comandaProdus)
        {
            await _comandaProdusService.Create(comandaProdus);
            return Ok();
        }

        [HttpPatch("updateComandaProdus")]
        public async Task<IActionResult> UpdateComandaProdus([FromBody] ComandaProdus comandaProdus)
        {
            await _comandaProdusService.Update(comandaProdus);
            return Ok();
        }

        [HttpDelete("delete/${id}")]
        public IActionResult DeleteProdus(Guid id)
        {
            _comandaProdusService.Delete(id);
            return Ok();
        }
    }
}
