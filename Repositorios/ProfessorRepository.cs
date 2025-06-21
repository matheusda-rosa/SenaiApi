using Microsoft.EntityFrameworkCore;
using SenaiAPI.Contexto;
using SenaiAPI.Entidades;
using SenaiAPI.Repositorios.Interfaces;

namespace SenaiAPI.Repositorios
{
    public class ProfessorRepository : BaseRepository<Professor>, IProfessorRepository
    {
        private readonly SenaiContext _context;

        public ProfessorRepository(SenaiContext context) : base(context)
        {
            _context = context;
        }
        public void Salvar(Professor professor)
        {
            base.Salvar(professor);
        }
        public IQueryable<Professor> PegarTodos()
        {
            return base.PegarTodos();
        }
        public async Task<bool> Delete(long Id)
        {
            return await base.Delete(Id);
        }
        public Professor ObterPorId(long Id)
        {
            return base.ObterPorId(Id);
        }

    }
}
