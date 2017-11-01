using AutoMapper;
using CurrencyExchangeAPI.Domain.Entities;
using CurrencyExchangeAPI.WebAPI.Models;

namespace CurrencyExchangeAPI.WebAPI.MappingProfileConf
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Currency, CurrencyModel>();
            CreateMap<CurrencyModel, Currency>();
        }
    }
}
