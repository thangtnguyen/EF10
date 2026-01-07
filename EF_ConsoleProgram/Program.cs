using EF_DBLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EF_ConsoleProgram;

class Program
{
    private static IConfigurationRoot _configuration;

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        BuildConfiguration();
        var connectionString = _configuration.GetConnectionString("EFDbConnection");
        Console.WriteLine($"Connection String: {connectionString}");
        //...additional code coming soon will go here
        Console.WriteLine("done");
    }

    private static void BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        _configuration = builder.Build();
    }
}
