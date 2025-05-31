using AutoMapper;
using SenaiAPI.DTos;
using SenaiAPI.Entidades;

namespace SenaiAPI.Mappers
{
    public class EscolaMapper : Profile
    {
        public EscolaMapper() 
        {
            CreateMap<EscolaDTo, Escola>().ReverseMap();
        }
    }
}
