namespace CleanArchitecture.WebApi.Configurations;

public interface IServiceInstaller
{
    void Install(IServiceCollection services, IConfiguration configuration, IHostBuilder host);
}
