using CleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar;
using CleanArchitecture.Domain.Dtos;
using CleanArchitecture.Presentation.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace CleanArchitecture.UnitTest
{
    public class CarsControllerUnitTest
    {
        [Fact]
        public async void Create_ReturnsOkResult_WhenRequestIsValid()
        {
            //Arrange
            var mediatorMock = new Mock<IMediator>();
            CreateCarCommand createCarCommand = new(
                "Toyota","Corolla",5000);
            MessageResponse response = new("Araç baþarýyla kaydedildi!");
            CancellationToken cancellationToken = new();

            mediatorMock.Setup(m => m.Send(createCarCommand, cancellationToken))
                .ReturnsAsync(response);

            CarsController carsController = new(mediatorMock.Object);

            //Act
            var result = await carsController.Create(createCarCommand, cancellationToken);

            //Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnValue = Assert.IsType<MessageResponse>(okResult.Value);

            Assert.Equal(response, returnValue);
            mediatorMock.Verify(m => m.Send(createCarCommand, cancellationToken), Times.Once);

        }
    }
}