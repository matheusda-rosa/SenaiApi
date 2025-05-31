using AutoMapper;
using SenaiAPI.Contexto;
using SenaiAPI.Repositorios;
using SenaiAPI.Repositorios.Interfaces;
using SenaiAPI.Servicos;
using SenaiAPI.Servicos.Interfaces;

namespace SenaiAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<SenaiContext>();
            builder.Services.AddScoped<IEscolaService, EscolaService>();
            builder.Services.AddScoped<IEscolaRepository, EscolaRepository>();

            MapperConfiguration mapperConfiguration = new(mapperConfig => { mapperConfig.AddMaps(new[] { "SenaiAPI" }); });
            builder.Services.AddSingleton(mapperConfiguration.CreateMapper());

            var app = builder.Build();
            app.UseSwagger();
            app.UseSwaggerUI();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
