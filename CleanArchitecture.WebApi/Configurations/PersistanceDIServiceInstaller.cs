using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Repositories;
using CleanArchitecture.Persistance.Context;
using CleanArchitecture.Persistance.Repositories;
using CleanArchitecture.Persistance.Services;
using CleanArchitecture.WebApi.Middleware;
using CleanArcihtecture.Infrastructure.Services;
using GenericRepository;

namespace CleanArchitecture.WebApi.Configurations;

public sealed class PersistanceDIServiceInstaller : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ICarService, CarService>();
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<IMailService, MailService>();
        services.AddScoped<IRoleService, RoleService>();
        services.AddScoped<IUserRoleService, UserRoleService>();

        services.AddTransient<ExceptionMiddleware>();
        services.AddScoped<IUnitOfWork, UnitOfWork<AppDbContext>>();
        services.AddScoped<ICarRepository, CarRepository>();
        services.AddScoped<IUserRoleRepository, UserRoleRepository>();
    }
}
