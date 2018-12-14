using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Winton.Extensions.Configuration.Consul;

namespace UserService.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cancellationTokenSource = new CancellationTokenSource();
            var hostBuilder = WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(
                    (hostingContext, builder) =>
                    {
                        var env = hostingContext.HostingEnvironment;
                        var consulAppSettings = $"{env.EnvironmentName}/{env.ApplicationName}/appsettings.json";
                        builder
                            .AddConsul(consulAppSettings,
                                cancellationTokenSource.Token,
                                options =>
                                {
                                    options.ConsulConfigurationOptions = cco =>
                                    {
                                        cco.Address = new Uri("http://localhost:8500");
                                    };
                                    options.Optional = true;
                                    options.ReloadOnChange = true;
                                    options.OnLoadException = exceptionContext => { exceptionContext.Ignore = true; };
                                })
                            .AddEnvironmentVariables();
                    })
                .UseStartup<Startup>();

            
            hostBuilder.Build().Run();

            cancellationTokenSource.Cancel();
        }
    }
}
