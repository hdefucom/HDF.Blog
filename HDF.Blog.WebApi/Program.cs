using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

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
                .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>().UseUrls("https://localhost:80"));
    }
}
