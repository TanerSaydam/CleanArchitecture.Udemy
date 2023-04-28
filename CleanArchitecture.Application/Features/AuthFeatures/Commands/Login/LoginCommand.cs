using MediatR;

namespace CleanArchitecture.Application.Features.AuthFeatures.Commands.Login;

public sealed record LoginCommand(
    string UserNameOrEmail,
    string Password) : IRequest<LoginCommandResponse>;
