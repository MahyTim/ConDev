using ConDev.Logic;
using ConDev.Logic.CreateUser;
using ConDev.Logic.Integrations;
using Microsoft.Extensions.DependencyInjection;

namespace ConDev.Integration.Email
{
    public static class ServiceRegistration
    {
        public static void RegisterEmailIntegration(this IServiceCollection services)
        {
            services.AddSingleton<IOutputIntegration, SendEmailIntegration>();
        }
    }
}