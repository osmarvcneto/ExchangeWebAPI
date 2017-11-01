using CurrencyExchangeAPI.Domain.Entities;
using CurrencyExchangeAPI.Domain.Interfaces.Repositories;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace CurrencyExchangeAPI.Repository.Repositories
{
    public class CurrencyRepository : RepositoryBase<Currency>, ICurrencyRepository
    {
        private static string Url = "https://economia.awesomeapi.com.br/";

        public IEnumerable<Currency> GetAll()
        {
            var result = JsonConvert.DeserializeObject<dynamic>(GetResult("all"));

            var results = new List<Currency>();

            foreach (var item in result)
            {
                results.Add(new Currency
                {
                    Ask = item.Value.ask,
                    Bid = item.Value.bid,
                    Code = item.Value.code,
                    High = item.Value.high,
                    Low = item.Value.low,
                    Name = item.Value.name,
                    VariationBid = item.Value.varBid,
                    PercentChange = item.Value.pctChange,
                    CreateDate = item.Value.create_date
                });
            }

            return results;
        }

        private string GetResult(string paramenters)
        {
            using (var httpClient = new HttpClient())
            {
                var content = httpClient.GetStringAsync(Url + paramenters);

                return content.Result;
            }
        }

        public Currency GetCurrency(string code)
        {
            var currency = JsonConvert.DeserializeObject<List<dynamic>>(GetResult(string.Format("{0}/1", code)));

            if (null != currency && currency.Count > 0)
            {
                return currency.Select(x =>
                new Currency
                {
                    Ask = x.ask,
                    Bid = x.bid,
                    Code = x.code,
                    High = x.high,
                    Low = x.low,
                    Name = x.name,
                    VariationBid = x.varBid,
                    PercentChange = x.pctChange,
                    CreateDate = x.create_date
                }
                ).FirstOrDefault();
            }

            return null;
        }
    }
}
