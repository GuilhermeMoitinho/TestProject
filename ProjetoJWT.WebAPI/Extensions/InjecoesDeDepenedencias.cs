using Microsoft.EntityFrameworkCore;
using ProjetoJWT.WebAPI.Application.Auth;
using ProjetoJWT.WebAPI.Application.interfaces;
using ProjetoJWT.WebAPI.Application.Services;
using ProjetoJWT.WebAPI.Data.db;
using ProjetoJWT.WebAPI.Data.repositories;
using ProjetoJWT.WebAPI.Domain.interfaces;

namespace ProjetoJWT.WebAPI.Extensions
{
    public static class InjecoesDeDepenedencias
    {
        public static void InjetarDependencias(this IServiceCollection service,
                                               IConfiguration configuration)
        {
            service.AddDbContext<AppDbContext>
               (op => op.UseSqlServer(configuration.GetConnectionString("ConexaoPadrao")));

            service.AddScoped<IEmployeeService, EmployeeService>();
            service.AddScoped<IUserService, UserService>();
            service.AddScoped<IEmployeeRepository, EmployeeRepository>();
            service.AddScoped<IUserRepository, UserRepository>();
            service.AddScoped<IUnitOfWork, UnitOfWork>();
            service.AddScoped<ITokenService, TokenService>();
        }
    }
}
