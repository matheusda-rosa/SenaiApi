using SenaiAPI.DTos;

namespace SenaiAPI.Servicos.Interfaces
{
    public interface IProfessorService
    {
        List<ProfessorDTo> BuscarTodos();
        public void Salvar(ProfessorDTo professorDTo);
        Task<bool> Delete(long Id);
        void Editar(ProfessorEdicaoDTo model);
    }
}
