﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ModulThird.BusinessLogic;
using ModulThird.Infrastructure;
using ModulThird.Services;
using MassTransit;
using ModulThird.Commands;
using ModulThird.Consumers;
using Microsoft.Extensions.Hosting;
using IHostingEnvironment = Microsoft.Extensions.Hosting.IHostingEnvironment;

namespace ModulThird
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddScoped<GetUsersInfoRequestHandler>();
            services.AddScoped<IUserInfoService, UserInfoService>();


            services.AddScoped<GetFilmsInfoRequestHandler>();
            services.AddScoped<IFilmInfoService, FilmInfoService>();

            services.AddScoped<GetSpoilersInfoRequestHandler>();
            services.AddScoped<ISpoilerInfoService, SpoilerInfoService>();

            services.AddScoped<AppendFilmsRequestHandler>();
            services.AddScoped<IFilmAddToService, FilmAddToService>();

            services.AddScoped<AppendFilmConsumer>();

            services.AddMassTransit(x =>
            {
                x.AddConsumer<AppendFilmConsumer>();
                x.AddBus(provider => MassTransit.Bus.Factory.CreateUsingInMemory(cfg =>
                {
                    cfg.ReceiveEndpoint("append-film-queue", ep =>
                    {
                        ep.ConfigureConsumer<AppendFilmConsumer>(provider);
                        EndpointConvention.Map<AppendFilmCommand>(ep.InputAddress);
                    });
                }));

                x.AddRequestClient<AppendFilmCommand>();
            });

            services.AddSingleton<IHostedService, BusService>();

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
