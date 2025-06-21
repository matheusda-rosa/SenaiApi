using Microsoft.AspNetCore.Mvc;
using SenaiAPI.DTos;
using SenaiAPI.Entidades;
using SenaiAPI.Servicos.Interfaces;

namespace SenaiAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfessorController : ControllerBase
    {
        private readonly IProfessorService _professorService;

        public ProfessorController(IProfessorService professorService)
        {
            _professorService = professorService;
        }

        [HttpPost]
        public IActionResult Adicionar(ProfessorDTo professor)
        {
            _professorService.Salvar(professor);
            return Ok();
        }

        [HttpGet("buscar-todos")]
        public IActionResult Buscar()
        {
            var professor = _professorService.BuscarTodos();
            return Ok(professor);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(long Id)
        {
            await _professorService.Delete(Id);
            return Ok();
        }

        [HttpPost("Editar")]
        public IActionResult Editar([FromBody] ProfessorEdicaoDTo professor)
        {
            if (professor != null)
            {
                return BadRequest("Professor não pode ser nulo");
                _professorService.Editar(professor);
            }
            return Ok();
        }
    }
}