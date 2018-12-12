using Autofac;
using ConDev.Logic;
using ConDev.Logic.CreateUser;
using Microsoft.Extensions.DependencyInjection;

namespace ConDev.Integration.Slack
{
    public static class ServiceRegistration
    {
        public static void RegisterSlackIntegration(this ContainerBuilder services)
        {
            services.RegisterType<PostToSlackChannelIntegration>().As<IOutputIntegration>();
        }
    }
}