using CleanArchitecture.Application.Abstractions;
using CleanArchitecture.WebApi.OptionsSetup;
using CleanArcihtecture.Infrastructure.Authenticaton;

namespace CleanArchitecture.WebApi.Configurations;

public sealed class InfrastructureServiceInstaller : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IJwtProvider, JwtProvider>();

        services.ConfigureOptions<JwtOptionsSetup>();
        services.ConfigureOptions<JwtBearerOptionsSetup>();
    }
}
