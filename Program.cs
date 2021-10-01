using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace serilog_config_sample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Use the following couple of lines to debug Serilog issues
            //var file = File.CreateText("failure.log");
            //Serilog.Debugging.SelfLog.Enable(TextWriter.Synchronized(file));

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                // Add Serilog as the logging provider. Serilog could be configured configured through appsettings.json
                .UseSerilog((context, services, configuration) => configuration
                    .ReadFrom.Configuration(context.Configuration))
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
