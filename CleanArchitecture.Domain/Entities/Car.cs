using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Domain.Entities;

public sealed class Car : Entity
{
    public string Name { get; set; }
    public string Model { get; set; }
    public int EnginePower { get; set; }
}
