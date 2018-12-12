using ConDev.Logic;
using Microsoft.Extensions.DependencyInjection;

namespace ConDev.DataAccess
{
    public static class ServiceRegistration
    {
        public static void RegisterDataAccess(this IServiceCollection services)
        {
            services.AddSingleton<IUserRepository, UserRepository>();
        }
    }
}