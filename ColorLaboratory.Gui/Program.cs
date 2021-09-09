using System;
using System.Windows.Forms;
using ColorLaboratory.Application.Services.Implementations;
using ColorLaboratory.Application.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ColorLaboratoryGui
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }
        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddScoped<IColorLaboratoryService, ColorLaboratoryServiceV1>();
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
