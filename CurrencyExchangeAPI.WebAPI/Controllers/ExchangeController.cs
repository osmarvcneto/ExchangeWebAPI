using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CurrencyExchangeAPI.Services.Interfaces;
using AutoMapper;
using CurrencyExchangeAPI.WebAPI.Models;
using CurrencyExchangeAPI.Domain.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CurrencyExchangeAPI.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ExchangeController : Controller
    {
        private readonly ICurrencyService _currencyService;
        private readonly IMapper _mapper;

        public ExchangeController(ICurrencyService currencyService, IMapper mapper)
        {

            _currencyService = currencyService;
            _mapper = mapper;
        }

        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            //Teste de commit
            return Ok(_mapper.Map<IEnumerable<Currency>, IEnumerable<CurrencyModel>>(_currencyService.GetAll()));
        }

        // GET api/values/5
        [HttpGet("{code}")]
        public IActionResult Get(string code)
        {
            return Ok(_mapper.Map<Currency, CurrencyModel>(_currencyService.GetCurrency(code)));
        }

    }
}
