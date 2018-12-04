using System;
using System.IO;
using Microsoft.Extensions;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync().GetAwaiter().GetResult();
        }

        private static async Task MainAsync()
        {
            AppType appType = AppType.Unknown;

            var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json");

            IConfiguration config = new ConfigurationBuilder()
              .AddJsonFile("appsettings.json", true, true)
              .Build();

            Console.WriteLine($"Welcome to {config["AppName"]}!");

            switch (config["AppType"])
            {
                case "Console":
                    {
                        appType = AppType.Console;
                        break;
                    }

                default:
                    {
                        appType = AppType.Unknown;
                        break;
                    }
            }

            IHelloWorldFactory helloWorldFactory = new HelloWorldFactory();

            IHelloWorld helloWorld = helloWorldFactory.CreateHelloWorld(appType);

            var message = await helloWorld.GetMessage();

            helloWorld.PrintMessage();

            Console.ReadLine();
        }
    }
}
