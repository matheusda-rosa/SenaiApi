using AutoMapper;
using SenaiAPI.DTos;
using SenaiAPI.Entidades;
using SenaiAPI.Repositorios.Interfaces;
using SenaiAPI.Servicos.Interfaces;

namespace SenaiAPI.Servicos
{
    public class ProfessorService : IProfessorService
    {
        private readonly IMapper _mapper;
        private readonly IProfessorRepository _professorRepository;

        public ProfessorService(IMapper mapper, IProfessorRepository professorRepository)
        {
            _mapper = mapper;
            _professorRepository = professorRepository;
        }
        public void Salvar(ProfessorDTo professorDTo)
        {
            var professor = _mapper.Map<Professor>(professorDTo);
            _professorRepository.Salvar(professor);
        }
        public List<ProfessorDTo> BuscarTodos()
        {
            var professor = _professorRepository.PegarTodos();
            return _mapper.Map<List<ProfessorDTo>>(professor);
        }
        public async Task<bool> Delete(long Id)
        {
            return await _professorRepository.Delete(Id);
        }
        public void Editar(EnderecoEdicaoDTo model)
        {
            var professor = _professorRepository.ObterPorId(model.Id);
            _mapper.Map(model, professor);

            _professorRepository.Salvar(professor);
        }

        public void Editar(ProfessorEdicaoDTo model)
        {
            throw new NotImplementedException();
        }
    }
}
