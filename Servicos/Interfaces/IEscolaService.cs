using Microsoft.AspNetCore.Mvc;
using SenaiAPI.DTos;
using SenaiAPI.Entidades;

namespace SenaiAPI.Servicos.Interfaces
{
    public interface IEscolaService
    {
        List<EscolaDTo> BuscarTodos();
        Task<bool> Delete(long Id);
        void Editar(EscolaEdicaoDTo escola);
        public Escola ObterPorId(long id);
        public void Salvar(EscolaDTo escolaDTo);
    }
}
