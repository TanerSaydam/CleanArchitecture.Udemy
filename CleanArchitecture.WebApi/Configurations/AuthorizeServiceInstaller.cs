namespace CleanArchitecture.WebApi.Configurations;

public sealed class AuthorizeServiceInstaller : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration)
    {
        services.AddAuthentication().AddJwtBearer();
        services.AddAuthorization();
    }
}
