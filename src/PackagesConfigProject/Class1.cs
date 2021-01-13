using NuGet.Versioning;

namespace PackagesConfigProject
{
    public class Class1
    {
        public void Method()
        {
            var version = NuGetVersion.Parse("1.0.0");

            System.Console.WriteLine(version);
        }
    }
}
