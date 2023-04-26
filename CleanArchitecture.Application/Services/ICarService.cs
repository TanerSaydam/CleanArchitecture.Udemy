using CleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar;

namespace CleanArchitecture.Application.Services;

public interface ICarService
{
    Task CreateAsync(CreateCarCommand request, CancellationToken cancellationToken);
}
