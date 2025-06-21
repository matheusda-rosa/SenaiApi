using AutoMapper;
using SenaiAPI.DTos;
using SenaiAPI.Entidades;

namespace SenaiAPI.Mappers
{
    public class EscolaMapper : Profile
    {
        public EscolaMapper() 
        {
            CreateMap<EscolaDTo, Escola>()
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Nome));
                
            CreateMap<EscolaDTo, Escola>().ReverseMap();

            CreateMap<EnderecoDTo, Endereco>().ReverseMap();
        }
    }
}
