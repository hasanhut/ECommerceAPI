using ECommerceAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceAPI.Application.Repositories.CustomerRepo;
using ECommerceAPI.Application.Repositories.OrderRepo;
using ECommerceAPI.Application.Repositories.ProductRepo;
using ECommerceAPI.Persistence.Repositories.CustomerRepo;
using ECommerceAPI.Persistence.Repositories.OrderRepo;
using ECommerceAPI.Persistence.Repositories.ProductRepo;

namespace ECommerceAPI.Persistence
{
    public static class ServiceRegisteration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(),"../../Presentation/ECommerceAPI.API"));
            configurationManager.AddJsonFile("appsettings.json");
            services.AddDbContext<DatabaseContext>(options => options.UseNpgsql(configurationManager.GetConnectionString("PostgreSQL")));
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
        }
    }
}
