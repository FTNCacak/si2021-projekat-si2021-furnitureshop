using BussniessLayer;
using DataAccessLayer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureShop
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var logIn = serviceProvider.GetRequiredService<LogIn>();
                Application.Run(logIn);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<IEmployeeBusiness, EmployeeBusiness>();
            services.AddScoped<IItemBusiness, ItemBusiness>();
            services.AddScoped<IOrderBusiness, OrderBusiness>();
            services.AddScoped<IOrderItemBusiness, OrderItemBusiness>();

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IItemRepository, ItemRepository>();
            services.AddScoped<IOrderItemRepository, OrderItemRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();



            services.AddScoped<LogIn>();
        }
    }
}
