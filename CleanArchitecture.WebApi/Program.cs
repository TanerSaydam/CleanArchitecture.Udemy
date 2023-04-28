using CleanArchitecture.WebApi.Configurations;
using CleanArchitecture.WebApi.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .InstallServices(
    builder.Configuration, typeof(IServiceInstaller).Assembly);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseMiddlewareExtensions();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
