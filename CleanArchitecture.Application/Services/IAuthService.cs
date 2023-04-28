using CleanArchitecture.Application.Features.AuthFeatures.Commands.CreateNewTokenByRefreshToken;
using CleanArchitecture.Application.Features.AuthFeatures.Commands.Login;
using CleanArchitecture.Application.Features.AuthFeatures.Commands.Register;

namespace CleanArchitecture.Application.Services;

public interface IAuthService
{
    Task RegisterAsync(RegisterCommand request);
    Task<LoginCommandResponse> LoginAsync(LoginCommand request, CancellationToken cancellationToken);
    Task<LoginCommandResponse> CreateTokenByRefreshTokenAsync(CreateNewTokenByRefreshTokenCommand request, CancellationToken cancellationToken);

}
