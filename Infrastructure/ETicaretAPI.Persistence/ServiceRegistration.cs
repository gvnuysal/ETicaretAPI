using ETicaretAPI.Application.Abstractions.Products;
using ETicaretAPI.Application.Repositories.Customers;
using ETicaretAPI.Application.Repositories.Orders;
using ETicaretAPI.Application.Repositories.Products;
using ETicaretAPI.Persistence.Concretes;
using ETicaretAPI.Persistence.Contexts;
using ETicaretAPI.Persistence.Repositories.Customers;
using ETicaretAPI.Persistence.Repositories.Orders;
using ETicaretAPI.Persistence.Repositories.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceService(this IServiceCollection services)
        {
            services.AddTransient<IProductService,ProductService>();
            services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));

            services.AddTransient<IProductReadRepository, ProductReadRepository>();
            services.AddTransient<IProductWriteRepository, ProductWriteRepository>();

            services.AddTransient<IOrderWriteRepository,OrderWriteRepository>();
            services.AddTransient<IOrderReadRepository,OrderReadRepository>();

            services.AddTransient<ICustomerReadRepository, CustomerReadRepository>();
            services.AddTransient<ICustomerWriteRepository, CustomerWriteRepository>();
        }
    }
}
