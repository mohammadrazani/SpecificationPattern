using Domain.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Services.Catalog.Interfaces;
using Services.Catalog.Services;

namespace API.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void ConfigureApiServices(this IServiceCollection services, IConfiguration configuration)
        {
            AddDefaultServices(services);

            AddDbContext(services, configuration);

            AddRepositories(services);

            AddServices(services);
        }

        private static void AddDefaultServices(IServiceCollection services)
        {
            services.AddControllers();
        }

        private static void AddDbContext(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }

        private static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
        }
    }
}
