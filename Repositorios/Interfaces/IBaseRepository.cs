namespace SenaiAPI.Repositorios.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        List<T> ObterTodos();
        void Salvar(T entidade);
        IQueryable<T> PegarTodos();
        Task<bool> Delete(long Id);
        T ObterPorId(long Id);
    }
}
