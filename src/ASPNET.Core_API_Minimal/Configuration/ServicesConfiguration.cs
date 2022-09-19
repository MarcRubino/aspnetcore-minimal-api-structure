using ASPNET.Core_API_Minimal.Modules.Employers.Services;
using ASPNET.Core_API_Minimal.Modules.Workers.Services;

namespace ASPNET.Core_API_Minimal
{
    public static class ServicesConfiguration
    {
        public static IServiceCollection ServicesRegistration(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new()
                {
                    Title = "ASP.NET Core Minimal API",
                    Version = "v1",
                    Description = "Minimal API Example"
                });
            });

            //Auto Register Modules
            services.RegisterModules();

            //Register Internal Services
            services.AddTransient<IWorkerService, WorkerService>();
            services.AddTransient<IEmployersService, EmployersService>();

            return services;
        }
    }
}
