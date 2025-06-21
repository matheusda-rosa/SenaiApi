using SenaiAPI.DTos;

namespace SenaiAPI.Servicos.Interfaces
{
    public interface IEnderecoService
    {
        List<EnderecoDTo> BuscarTodos();
        public void Salvar(EnderecoDTo enderecoDTo);
        Task<bool> Delete(long Id);
        void Editar(EnderecoEdicaoDTo model);
    }
}