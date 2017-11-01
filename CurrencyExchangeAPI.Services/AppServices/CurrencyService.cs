using System.Collections.Generic;
using CurrencyExchangeAPI.Domain.Entities;
using CurrencyExchangeAPI.Domain.Interfaces.Repositories;
using CurrencyExchangeAPI.Services.Interfaces;

namespace CurrencyExchangeAPI.Services.AppServices
{
    public class CurrencyService : ServiceBase<Currency>, ICurrencyService
    {
        private readonly ICurrencyRepository rep;

        public CurrencyService(ICurrencyRepository repository) : base(repository)
        {
            rep = repository;
        }

        public IEnumerable<Currency> GetAll()
        {
            return rep.GetAll();
        }

        public Currency GetCurrency(string code)
        {
            return rep.GetCurrency(code);
        }
    }
}
