using ConDev.Logic.CreateUser;
using Microsoft.Extensions.DependencyInjection;

namespace ConDev.Logic
{
    public static class ServiceRegistration
    {
        public static void RegisterLogic(this IServiceCollection services)
        {
            services.AddSingleton<ICreateUserCommand, CreateUserCommand>();
        }
    }
}