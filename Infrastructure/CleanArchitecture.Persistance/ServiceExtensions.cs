using Infrastructure.CleanArchitecture.Persistance.Repositories;
using Core.CleanArchitecture.Domain.Interfaces;
using Infrastructure.CleanArchitecture.Persistance.Context;

namespace Infrastructure.CleanArchitecture.Persistance
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistenceApp(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("Sqlite");
            services.AddDbContext<AppDbContext>(options => 
            {
                options.UseSqlite(connectionString);
            });

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}