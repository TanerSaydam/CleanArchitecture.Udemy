using System.Reflection;

namespace CleanArchitecture.Application;

public static class AssemblyReference
{
    public static readonly Assembly Assembly = typeof(Assembly).Assembly;
}
