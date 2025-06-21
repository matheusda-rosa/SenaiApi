using SenaiAPI.DTos;
using SenaiAPI.Entidades;

namespace SenaiAPI.Repositorios.Interfaces
{
    public interface IEscolaRepository
    {
        void Salvar(Escola escola);
        Task<bool> Delete(long Id);
        Escola ObterPorId(long Id);
        List<Escola> PegarTodos();
    }
}
