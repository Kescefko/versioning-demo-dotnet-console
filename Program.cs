using System;

namespace VersioningDemo
{
    class Program
    {
        // The version number will be manually set based on the versioning strategy
        static string version = "v0.0.0";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Azure DevOps!");
            Console.WriteLine($"Version: {version}");
        }
    }
}
