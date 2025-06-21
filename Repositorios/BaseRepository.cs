using Microsoft.EntityFrameworkCore;
using SenaiAPI.Contexto;
using SenaiAPI.Entidades;
using SenaiAPI.Repositorios.Interfaces;

namespace SenaiAPI.Repositorios
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly SenaiContext _context;
        DbSet<T> _dbSet;
        public BaseRepository(SenaiContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public List<T> ObterTodos()
        {
            return _dbSet.ToList();
        }
        public void Salvar(T entidade)
        {
            if (entidade.Id == 0)
                _dbSet.Add(entidade);
            else
                _dbSet.Update(entidade);
            _context.SaveChanges();
        }
        public IQueryable<T> PegarTodos()
        {
            return _dbSet;
        }
        public async Task<bool> Delete(long Id)
        {
            try
            {
                await _dbSet.Where(c => c.Id == Id).ExecuteDeleteAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public T ObterPorId(long Id)
        {
            return _dbSet.FirstOrDefault(e => e.Id == Id);
        }
    }
}
