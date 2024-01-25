using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project1.Data.Models;
using Project1.Services.ComandaService;
using Project1.Services.UtilizatorService;

namespace Project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComandaController : ControllerBase
    {
        private readonly IComandaService _comandaService;

        public ComandaController(IComandaService comandaService)
        {
            _comandaService = comandaService;
        }

        [HttpGet("allComenzi")]
        public async Task<IActionResult> GetComenzi()
        {
            return Ok(await _comandaService.GetAll());
        }

        [HttpPost("createComanda")]
        public async Task<IActionResult> CreateComanda([FromBody] Comanda comanda)
        {
            await _comandaService.Create(comanda);
            return Ok();
        }

        [HttpPatch("updateComanda")]
        public async Task<IActionResult> UpdateComanda([FromBody] Comanda comanda)
        {
            await _comandaService.Update(comanda);
            return Ok();
        }

        [HttpDelete("delete/${id}")]
        public IActionResult DeleteUtilizator(Guid id)
        {
            _comandaService.Delete(id);
            return Ok();
        }
    }
}
