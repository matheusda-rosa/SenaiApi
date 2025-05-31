using SenaiAPI.Entidades;

namespace SenaiAPI.Repositorios.Interfaces
{
    public interface IEscolaRepository
    {
        List<Escola> PegarTodos();
        void Salvar(Escola escola);
    }
}
