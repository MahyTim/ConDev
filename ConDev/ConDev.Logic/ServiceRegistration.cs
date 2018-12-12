using Autofac;
using Autofac.Multitenant;
using ConDev.Logic.CreateUser;
using Microsoft.Extensions.DependencyInjection;

namespace ConDev.Logic
{
    public static class ServiceRegistration
    {
        public static void RegisterLogic(this ContainerBuilder services)
        {
            services.RegisterType<CreateUserCommand>().As<ICreateUserCommand>().InstancePerTenant();
            services.RegisterType<SlowStartup>().AsSelf();
        }
    }
}