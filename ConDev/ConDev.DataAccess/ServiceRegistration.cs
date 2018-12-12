using Autofac;
using Autofac.Multitenant;
using ConDev.Logic;
using Microsoft.Extensions.DependencyInjection;

namespace ConDev.DataAccess
{
    public static class ServiceRegistration
    {
        public static void RegisterDataAccess(this MultitenantContainer services)
        {
            services.ConfigureTenant("1", z =>
            {
                z.RegisterType<UserRepositoryForCustomerX>().As<IUserRepository>();
            });
        }

        public static void RegisterDataAccess(this ContainerBuilder services)
        {
            services.RegisterType<UserRepository>().As<IUserRepository>();
        }
    }
}