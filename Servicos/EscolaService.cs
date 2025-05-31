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
    }
}
