using SenaiAPI.DTos;
using SenaiAPI.Entidades;

namespace SenaiAPI.Servicos.Interfaces
{
    public interface IEscolaService
    {
        List<EscolaDTo> BuscarTodos();
        void Salvar(EscolaDTo escola);
    }
}
