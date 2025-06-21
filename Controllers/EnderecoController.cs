using Microsoft.AspNetCore.Mvc;
using SenaiAPI.DTos;
using SenaiAPI.Entidades;
using SenaiAPI.Servicos;
using SenaiAPI.Servicos.Interfaces;

namespace SenaiAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        [HttpPost]
        public IActionResult Adicionar(EnderecoDTo endereco)
        {
            _enderecoService.Salvar(endereco);
            return Ok();
        }

        [HttpGet("buscar-todos")]
        public IActionResult Buscar()
        {
            var endereco = _enderecoService.BuscarTodos();
            return Ok(endereco);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(long Id)
        {
            await _enderecoService.Delete(Id);
            return Ok();
        }

        [HttpPost("Editar")]
        public IActionResult Editar([FromBody] EnderecoEdicaoDTo enderecoEdicaoDTo)
        {
            if (enderecoEdicaoDTo != null)
            {
                return BadRequest("Escola não pode ser nula");
                _enderecoService.Editar(enderecoEdicaoDTo);
            }
            return Ok();
        }
    }
}