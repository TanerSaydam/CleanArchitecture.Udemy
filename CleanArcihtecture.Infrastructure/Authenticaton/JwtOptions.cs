namespace CleanArcihtecture.Infrastructure.Authenticaton;

public sealed class JwtOptions
{
    public string Issuer { get; set; }
    public string Audience { get; set; }
    public string SecretKey { get; set; }
}
