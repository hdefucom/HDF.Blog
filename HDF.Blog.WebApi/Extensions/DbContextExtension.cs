using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace HDF.Blog.WebApi.Extensions
{
    /// <summary>
    /// 数据库拓展
    /// </summary>
    public static class DbContextExtension
    {

        ///// <summary>
        ///// 配置DbContext
        ///// </summary>
        ///// <param name="services"></param>
        ///// <param name="action"></param>
        //public static void AddDbContextService(this IServiceCollection services, Action<DbContextOptionsBuilder> action)
        //{
        //    ILoggerFactory consoleLoggerFactory = LoggerFactory.Create(builder =>
        //    {
        //        builder.AddFilter((category, level) => category == DbLoggerCategory.Database.Command.Name && level == LogLevel.Information)
        //            .AddConsole();
        //    });
        //    services.AddDbContext<GTCMCDSContext>(options =>
        //    {
        //        options.UseLoggerFactory(consoleLoggerFactory);
        //        options.EnableSensitiveDataLogging();
        //        action?.Invoke(options);
        //    });
        //}


        ///// <summary>
        ///// 配置MySqlContext
        ///// </summary>
        ///// <param name="services"></param>
        ///// <param name="connectionString"></param>
        //public static void AddMySqlContextService(this IServiceCollection services, string connectionString)
        //{
        //    ILoggerFactory consoleLoggerFactory = LoggerFactory.Create(builder =>
        //    {
        //        builder.AddFilter((category, level) => category == DbLoggerCategory.Database.Command.Name && level == LogLevel.Information)
        //            .AddConsole();
        //    });
        //    services.AddDbContext<MySqlContext>(options =>
        //    {
        //        options.UseLoggerFactory(consoleLoggerFactory);
        //        options.EnableSensitiveDataLogging();
        //        options.UseMySql(connectionString);
        //    });
        //}
    }
}
