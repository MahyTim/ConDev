using Autofac;
using ConDev.Logic;
using ConDev.Logic.CreateUser;
using Microsoft.Extensions.DependencyInjection;

namespace ConDev.Integration.Email
{
    public static class ServiceRegistration
    {
        public static void RegisterEmailIntegration(this ContainerBuilder services)
        {
            services.RegisterType<SendEmailIntegration>().As<IOutputIntegration>().SingleInstance();
        }
    }
}