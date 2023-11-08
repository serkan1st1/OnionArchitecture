using System.Reflection;

namespace OnionArchitecture.Domain
{
    public static class AssemblyReference
    {
        public static readonly Assembly Assembly = typeof(Assembly).Assembly;
    }
}
