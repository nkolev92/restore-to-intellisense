using NuGet.Versioning;
using System;

namespace SDKPackageReferenceProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var version = NuGetVersion.Parse("1.0.0");

            Console.WriteLine(version);
        }
    }
}
