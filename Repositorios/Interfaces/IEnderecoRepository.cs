using SenaiAPI.Entidades;

namespace SenaiAPI.Repositorios.Interfaces
{
    public interface IEnderecoRepository
    {
        void Salvar(Endereco endereco);
        Task<bool> Delete(long Id);
        Endereco ObterPorId(long Id);
        List<Endereco> PegarTodos();
    }
}
