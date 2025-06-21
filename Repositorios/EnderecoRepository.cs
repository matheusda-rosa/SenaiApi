using Microsoft.EntityFrameworkCore;
using SenaiAPI.Contexto;
using SenaiAPI.Entidades;
using SenaiAPI.Repositorios.Interfaces;

namespace SenaiAPI.Repositorios
{
    public class EnderecoRepository : BaseRepository<Endereco>, IEnderecoRepository
    {
        private readonly SenaiContext _context;

        public EnderecoRepository(SenaiContext context) : base(context)
        {
            _context = context;
        }
        public void Salvar(Endereco endereco)
        {
            base.Salvar(endereco);
        }
        public List<Endereco> PegarTodos()
        {
            return base.PegarTodos().ToList();
        }
        public async Task<bool> Delete(long Id)
        {
            return await base.Delete(Id);
        }
        public Endereco ObterPorId(long Id)
        {
            return base.ObterPorId(Id);
        }
    }
}