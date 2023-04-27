using CleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar;
using CleanArchitecture.Domain.Dtos;
using CleanArchitecture.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Presentation.Controllers;

public sealed class CarsController : ApiController
{
    public CarsController(IMediator mediator) : base(mediator) {}

    [HttpPost("[action]")]
    public async Task<IActionResult> Create(CreateCarCommand request, CancellationToken cancellationToken)
    {
        MessageResponse response =  await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpGet]
    public IActionResult Calculate()
    {
        int x = 0;
        int y = 0;
        int result = x / y;
        return Ok();
    }
}
