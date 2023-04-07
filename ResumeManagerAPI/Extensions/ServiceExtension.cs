using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ResumeManagerAPI.Data;
using ResumeManagerAPI.Mappings;
using ResumeManagerAPI.Services.Interface;
using ResumeManagerAPI.Services.Service;
using ResumeManagerAPI.UnitOfWork.Interfaces;
using ResumeManagerAPI.UnitOfWork.Services;
using System.Text.Json.Serialization;

namespace ResumeManagerAPI.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
           services.AddDbContext<AppDbContext>(
               opts => opts.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        #region MAPPING CONFIGS
        public static void ConfigureMapping(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(map =>
            {
                map.AddProfile<MappingConfig>();
                
            });

            services.AddSingleton(mapperConfig.CreateMapper());
        }
        #endregion

        #region DEPENDENCIES
        public static void ConfigurServiceManager(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, ServiceManager>();
        }

        #endregion

        //public static void ConfigureJsonOptions(this IServiceCollection services, IMvcBuilder, Action<MvcJsonOptions> configureJson)
        //{
        //    services.Configure<JsonOptions>(options =>
        //    {
        //        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
        //    });
        //    services.AddMvc().AddJsonOptions(configureJson);
        //}
    }
}
