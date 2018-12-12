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
            services.RegisterType<CreateUserCommand>().Named<ICreateUserCommand>("inner");
            services.RegisterDecorator<ICreateUserCommand>((c, z) => new CreateUserCommandMaatwerk(z), fromKey: "inner");

            services.RegisterType<SlowStartup>().AsSelf();
        }
    }
}