using API_Banco.Scr.Repositorios;
using API_Banco.Scr.Repositorios.Implementações;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static API_Banco.Scr.Modelos.Contextos.Contextos;

namespace API_Banco
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
            // Configuração de Banco de dados
            services.AddDbContext<API_BancoContexto>(opt => opt.UseSqlServer(Configuration["ConnectionStringsDev:DefaultConnection"]));

            // Repositorios
            services.AddScoped<IDadosCliente, ClienteRepositorio>();

            // Controladores
            services.AddCors();
            services.AddControllers();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, API_BancoContexto contexto)
        {
            // Ambiente de Desenvolvimento
            if (env.IsDevelopment())
            {
                contexto.Database.EnsureCreated();
                app.UseDeveloperExceptionPage();
            }
            // Ambiente de produção
            contexto.Database.EnsureCreated();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // Rotas
            app.UseRouting();
            app.UseCors(c => c
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
