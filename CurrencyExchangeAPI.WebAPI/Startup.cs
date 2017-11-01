using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using CurrencyExchangeAPI.Services.Interfaces;
using CurrencyExchangeAPI.Services.AppServices;
using CurrencyExchangeAPI.Domain.Interfaces.Repositories;
using CurrencyExchangeAPI.Repository.Repositories;
using AutoMapper;

namespace CurrencyExchangeAPI.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddAutoMapper();

            services.AddTransient(typeof(IServiceBase<>), typeof(ServiceBase<>));
            services.AddTransient<ICurrencyService, CurrencyService>();

            services.AddTransient(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddTransient<ICurrencyRepository, CurrencyRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
