using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Net;

namespace HDF.Blog.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureLogging(loggingBuilder => loggingBuilder.AddLog4Net())
                .ConfigureWebHostDefaults(webBuilder => webBuilder
                .UseStartup<Startup>()
                //.ConfigureKestrel(options =>
                //{
                //    options.Listen(IPAddress.Any, 443, listenOptions =>
                //    {
                //        listenOptions.Protocols = HttpProtocols.Http2;
                //        listenOptions.UseHttps("www.hdefu.com.pfx", "foyNELFS");
                //    });

                //})
                //.UseUrls("https://*:443")
                
                //.UseUrls("http://*:80")
            );
    }
}
