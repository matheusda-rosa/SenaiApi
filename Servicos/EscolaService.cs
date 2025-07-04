﻿using AutoMapper;
using SenaiAPI.DTos;
using SenaiAPI.Entidades;
using SenaiAPI.Repositorios;
using SenaiAPI.Repositorios.Interfaces;
using SenaiAPI.Servicos.Interfaces;

namespace SenaiAPI.Servicos
{
    public class EscolaService : IEscolaService
    {
        private readonly IMapper _mapper;
        private readonly IEscolaRepository _escolaRepository;
        public EscolaService(IMapper mapper, IEscolaRepository escolaRepository)
        {
            _mapper = mapper;
            _escolaRepository = escolaRepository;
        }
        public void Salvar(EscolaDTo escolaDTo)
        {
            var escola = _mapper.Map<Escola>(escolaDTo);
            _escolaRepository.Salvar(escola);
        }
        public List<EscolaDTo> BuscarTodos() 
        {
            var escolas = _escolaRepository.PegarTodos();
            return _mapper.Map<List<EscolaDTo>>(escolas);
        }
        public async Task<bool> Delete(long Id)
        {
            return await _escolaRepository.Delete(Id);
        }
        public void Editar(EscolaEdicaoDTo model)
        {
            var escola = _escolaRepository.ObterPorId(model.Id);
            _mapper.Map(model, escola);

            _escolaRepository.Salvar(escola);
        }
        public EscolaDTo ObterPorId(long id)
        {
            var escola = _mapper.Map<EscolaDTo>(_escolaRepository.ObterPorId(id));
            return escola;
        }
    }
}
