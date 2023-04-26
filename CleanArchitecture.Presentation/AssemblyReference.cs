using System.Reflection;

namespace CleanArchitecture.Presentation;

public static class AssemblyReference
{
    public static readonly Assembly Assembly = typeof(Assembly).Assembly;
}
