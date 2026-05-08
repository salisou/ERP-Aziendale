using ApsnetCoreMVC.Dtos;
using AutoMapper;
using Models;

namespace ApsnetCoreMVC.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap<FatturaDto, Fattura>();
            CreateMap<Fattura, FatturaDto>().ReverseMap();
        }
    }
}

// dotnet remove package AutoMapper.Extensions.Microsoft.DependencyInjection