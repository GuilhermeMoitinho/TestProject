
using Microsoft.EntityFrameworkCore;
using ProjetoJWT.WebAPI.Application.interfaces;
using ProjetoJWT.WebAPI.Application.Services;
using ProjetoJWT.WebAPI.Data.db;
using ProjetoJWT.WebAPI.Data.repositories;
using ProjetoJWT.WebAPI.Domain.Entities;
using ProjetoJWT.WebAPI.Domain.interfaces;
using ProjetoJWT.WebAPI.Extensions;

namespace ProjetoJWT.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.InjetarDependencias(builder.Configuration);

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwagger();
            builder.Services.AddAuthanticationJwt(builder.Configuration);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
