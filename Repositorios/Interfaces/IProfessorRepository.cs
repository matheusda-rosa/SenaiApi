using SenaiAPI.Entidades;

namespace SenaiAPI.Repositorios.Interfaces
{
    public interface IProfessorRepository
    {

        IQueryable<Professor> PegarTodos();
        void Salvar(Professor professor);
        Task<bool> Delete(long Id);
        Professor ObterPorId(long Id);
    }
}
