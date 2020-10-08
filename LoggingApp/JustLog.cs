using System;
using System.IO;
using Destructurama;
using LoggingApp.Models;
using Microsoft.ApplicationInsights.DependencyCollector;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace LoggingApp
{
    class JustLog
    {
        static void Main(string[] args)
        {            
            var configuration = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json")
                                .Build();

            Log.Logger = new LoggerConfiguration()                            
                            .ReadFrom.Configuration(configuration)
                            .Destructure.UsingAttributes()
                            .CreateLogger();

            Log.Information("Just Logging!");
            int a = 10, b = 0;
            try
            {
                Log.Debug("Dividing {A} by {B}", a, b);
                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException ex)
            {
                Log.Error(ex, "Can't divide by zero!");
            }

            User user = new User { FirstName = "Jerry", LastName = "Seinfeld", DateOfBirth = new DateTime(1960, 7, 8), PhoneNumber = "213-111-1111", Ssn="123-123-1234"};
            Log.Information("User info: {@user}", user);          

            Log.CloseAndFlush();
            
            Console.ReadKey();
        }
    }
}
