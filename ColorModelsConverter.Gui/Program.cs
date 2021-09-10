using System;
using System.Windows.Forms;
using ColorModelsConverter.Application.Services.Implementations;
using ColorModelsConverter.Application.Services.Interfaces;
using ColorModelsConverter.Mapper.MapProfiles;
using MapsterMapper;
using Microsoft.Extensions.DependencyInjection;

namespace ColorModelsConverterGui
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }
        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddScoped<IColorModelsConverterService, ColorModelsConverterServiceV1>();

            services.AddSingleton(CmykMapProfile.GetConfiguredMappingConfig());
            services.AddSingleton(HslMapProfile.GetConfiguredMappingConfig());
            services.AddSingleton(HsvMapProfile.GetConfiguredMappingConfig());
            services.AddSingleton(IttenMapProfile.GetConfiguredMappingConfig());
            services.AddSingleton(RgbMapProfile.GetConfiguredMappingConfig());
            services.AddScoped<IMapper, ServiceMapper>();

            ServiceProvider = services.BuildServiceProvider();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            Application.Run(new Form1());
        }
    }
}
