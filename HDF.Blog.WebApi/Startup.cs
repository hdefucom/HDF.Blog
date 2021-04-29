using HDF.Blog.Model.ApiModel;
using HDF.Blog.Model.AppsettingModel;
using HDF.Blog.WebApi.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Net;

namespace HDF.Blog.WebApi
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// 配置服务
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            //映射配置到实体
            var settings = _configuration.GetSection("AppSettings").Get<AppSettings>();
            services.AddSingleton(settings)
                    .AddSingleton(settings.TokenConfig)
                    .AddSingleton(settings.CorsConfig)
                    .AddSingleton(settings.SpaConfig);
            //映射Token信息到实体
            services.AddHttpContextAccessor();
            services.AddScoped(typeof(AccessToken));

            ////添加对AutoMapper的支持，会查找所有程序集中继承了 Profile 的类
            //services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            //添加控制器服务，配置Json序列化服务
            services.AddControllers().AddNewtonsoftJsonService();

            //添加DBContext服务
            //if (settings.DbType == DBType.SqlServer)
            //    services.AddDbContextService(options => options.UseSqlServer(settings.ConnectionStrings["GTCMCDS"]));
            //if (settings.DbType == DBType.MySql)
            //    services.AddDbContextService(options => options.UseMySql(settings.ConnectionStrings["MySqlDB"]));
            //services.AddEmrContextService(settings.ConnectionStrings["EMRDB"]);

            //添加api版本控制服务
            services.AddApiVersioningService();
            //添加Swagger服务
            services.AddSwaggerService();
            //添加身份认证服务
            services.AddAuthenticationService(settings.TokenConfig);
            //添加跨域服务
            services.AddCorsService(settings.CorsConfig);
            //添加SPA服务
            services.AddSpaService(settings.SpaConfig);


            //services.AddHttpsRedirection(options =>
            //{
            //    options.RedirectStatusCode = (int)HttpStatusCode.TemporaryRedirect;
            //    options.HttpsPort = 443;
            //});

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApiVersionDescriptionProvider provider, AppSettings settings)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHsts();
            //app.UseHttpsRedirection(); // https重定向

            app.UseSwaggerMiddleware(provider);// 配置swagger中间件

            app.UseAuthentication();//身份验证

            app.UseRouting();

            app.UserCorsMiddleware(settings.CorsConfig);//配置跨域策略

            app.UseAuthorization();//授权

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                //SignalR  hub ...
            });

            app.UseSpaMiddleware(env, settings.SpaConfig);//配置SPA中间件
        }



        ///// <summary>
        ///// Autofac容器配置
        ///// </summary>
        ///// <param name="builder"></param>
        //public void ConfigureContainer(ContainerBuilder builder)
        //{
        //    // ****************************************************************
        //    // Gocent.GTCMCDS.WebApi项目已经与Gocent.GTCMCDS.Services解耦，无需引用
        //    // 现引用Gocent.GTCMCDS.IServices抽象层
        //    // 已经解耦但又引用原因，网站发布只会发布引用的项目文件，添加Services项目引用是为了发布方便
        //    // ****************************************************************

        //    //项目解耦，抽象实现dll(Server、Repository)需复制到运行目录下
        //    var basePath = Microsoft.DotNet.PlatformAbstractions.ApplicationEnvironment.ApplicationBasePath;
        //    var servicesDllFile = Path.Combine(basePath, "Gocent.GTCMCDS.Services.dll");//获取注入项目绝对路径

        //    Assembly service = Assembly.LoadFile(servicesDllFile);//直接采用加载文件的方法
        //    builder.RegisterAssemblyTypes(service).Where(t => t.Name.EndsWith("Services"))
        //        .AsImplementedInterfaces()
        //        .InstancePerDependency();
        //    //.EnableInterfaceInterceptors()//引用Autofac.Extras.DynamicProxy;
        //    //.InterceptedBy(cacheType.ToArray());//允许将拦截器服务的列表分配给注册。

        //}












    }
}
