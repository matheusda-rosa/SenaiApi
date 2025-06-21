using Microsoft.EntityFrameworkCore;
using SenaiAPI.Contexto;
using SenaiAPI.DTos;
using SenaiAPI.Entidades;
using SenaiAPI.Repositorios.Interfaces;
using SenaiAPI.Servicos.Interfaces;

namespace SenaiAPI.Repositorios
{
    public class EscolaRepository : BaseRepository<Escola>, IEscolaRepository
    {
        private readonly SenaiContext _context;
        public EscolaRepository(SenaiContext context) : base(context)
        {
            _context = context;
        }
        public void Salvar(Escola escola)
        {
            base.Salvar(escola);
        }
        public List<Escola> PegarTodos()
        {
            return base.PegarTodos()
                .Include(c => c.Endereco)
                .Include(c => c.Professores)
                .ToList();
        }
        public async Task<bool> Delete(long Id)
        {
            return await base.Delete(Id);
        }

        public Escola ObterPorId(long Id)
        {
            return base.ObterPorId(Id);
        }
    }
}
