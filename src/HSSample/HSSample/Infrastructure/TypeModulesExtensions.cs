using System;
using System.Text.RegularExpressions;

namespace HSSample.Infrastructure
{
    public static class TypeModulesExtensions
    {
        private static readonly Regex ExtractModuleRegex = new Regex(@"\.Modules\.(?<Module>.*)\.");

        public static bool IsInAppModule(this Type type)
        {
            if (type == null)
                throw new ArgumentNullException("type");

            return ExtractModuleRegex.IsMatch(type.FullName ?? "");
        }

        public static string GetAppModule(this Type type)
        {
            if (type == null)
                throw new ArgumentNullException("type");

            var match = ExtractModuleRegex.Match(type.FullName ?? "");

            if (!match.Success)
                throw new ArgumentException("Type must be in an application module to get the module", "type");

            return match.Groups["Module"].Value;
        }

        public static bool IsNullImplementation(this Type type)
        {
            if (type == null)
                throw new ArgumentNullException("type");

            return type.Name.StartsWith("Null");
        }

        public static bool IsNotNullImplementation(this Type type)
        {
            return !IsNullImplementation(type);
        }
    }
}