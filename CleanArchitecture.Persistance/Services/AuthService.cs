using AutoMapper;
using CleanArchitecture.Application.Features.AuthFeatures.Commands.Register;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace CleanArchitecture.Persistance.Services;

public sealed class AuthService : IAuthService
{
    private readonly UserManager<User> _userManager;
    private readonly IMapper _mapper;
    public AuthService(UserManager<User> userManager, IMapper mapper)
    {
        _userManager = userManager;
        _mapper = mapper;
    }

    public async Task RegisterAsync(RegisterCommand request)
    {
        User user = _mapper.Map<User>(request);
        IdentityResult result = await _userManager.CreateAsync(user,request.Password);
        if(!result.Succeeded)
        {
            throw new Exception(result.Errors.First().Description);
        }
    }
}
