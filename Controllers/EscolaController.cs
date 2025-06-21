using Microsoft.AspNetCore.Mvc;
using SenaiAPI.DTos;
using SenaiAPI.Entidades;
using SenaiAPI.Servicos.Interfaces;

namespace SenaiAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EscolaController : ControllerBase
    {
        private readonly IEscolaService _escolaService;

        public EscolaController(IEscolaService escolaService)
        {
            _escolaService = escolaService;
        }

        [HttpPost]
        public IActionResult Salvar([FromBody] EscolaDTo escola)
        {
            if (escola == null)
            
                 return BadRequest("Escola não pode ser nula");
             _escolaService.Salvar(escola);
             return Ok();
            
        }

        [HttpGet("buscar-todos")]
        public IActionResult Buscar()
        {
            var escolas = _escolaService.BuscarTodos();
            return Ok(escolas);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(long Id)
        {
            await _escolaService.Delete(Id);
            return Ok();
        }

        [HttpGet("PegarPorId")]
        public IActionResult PegarPorId(long id)
        {
            var escolas = _escolaService.ObterPorId(id);
            return Ok(escolas);
        }
    }
}