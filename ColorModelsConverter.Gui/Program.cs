using System;
using System.Windows.Forms;
using ColorModelsConverter.Application.Services.Implementations;
using ColorModelsConverter.Application.Services.Interfaces;
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
