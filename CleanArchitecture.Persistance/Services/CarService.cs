using CleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Persistance.Context;

namespace CleanArchitecture.Persistance.Services;

public sealed class CarService : ICarService
{
    private readonly AppDbContext _context;

    public CarService(AppDbContext context)
    {
        _context = context;
    }

    public async Task CreateAsync(CreateCarCommand request, CancellationToken cancellationToken)
    {
        Car car = new()
        {
            Name = request.Name,
            Model = request.Model,
            EnginePower = request.EnginePower
        };

        await _context.Set<Car>().AddAsync(car, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }
}
