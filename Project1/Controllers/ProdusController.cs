using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project1.Data.Models;
using Project1.Services.ProdusService;
using Project1.Services.UtilizatorService;

namespace Project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdusController : ControllerBase
    {
        private readonly IProdusService _produsService;

        public ProdusController(IProdusService produsService)
        {
            _produsService = produsService;
        }

        [HttpGet("allProduse")]
        public async Task<IActionResult> GetProduse()
        {
            return Ok(await _produsService.GetAll());
        }

        [HttpPost("createProdus")]
        public async Task<IActionResult> CreateProdus([FromBody] Produs produs)
        {
            await _produsService.Create(produs);
            return Ok();
        }

        [HttpPatch("updateProdus")]
        public async Task<IActionResult> UpdateProdus([FromBody] Produs produs)
        {
            await _produsService.Update(produs);
            return Ok();
        }

        [HttpDelete("delete/${id}")]
        public IActionResult DeleteProdus(Guid id)
        {
            _produsService.Delete(id);
            return Ok();
        }
    }
}
