using ApsnetCoreMVC.Dtos;
using AutoMapper;
using Models;

namespace ApsnetCoreMVC.Mappings
{
    public class MappingProfile : Profile
    {
        protected MappingProfile()
        {
            CreateMap<FatturaDto, Fattura>();
            CreateMap<Fattura, FatturaDto>();
        }
    }
}
