namespace Core.CleanArchitecture.Application.Services
{
    public static class ServiceExtensions
    {
        public static void ConfigureApplicationApp(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg => cfg.RegisterServiceFromAssembly(Assembly.GetExecutingAssembly()));
            services.AddValidatiorsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}