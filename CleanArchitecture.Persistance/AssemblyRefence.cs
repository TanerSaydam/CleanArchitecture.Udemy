using System.Reflection;

namespace CleanArchitecture.Persistance;

public static class AssemblyRefence
{
    public static readonly Assembly Assembly = typeof(Assembly).Assembly;
}
