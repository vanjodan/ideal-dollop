using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using BoxingChampionship.Providers;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI;

namespace BoxingChampionship
{
    public static class DependencyConfig
    {
        public static IContainer RegisterDependencyResolvers()
        {
            ContainerBuilder builder = new ContainerBuilder();
            RegisterDependencyMappingDefaults(builder);
            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            return container;
        }

        private static void RegisterDependencyMappingDefaults(ContainerBuilder builder)
        {
            Assembly coreAssembly = Assembly.GetAssembly(typeof(IStateManager));
            Assembly webAssembly = Assembly.GetAssembly(typeof(MvcApplication));

            builder.RegisterAssemblyTypes(coreAssembly).AsImplementedInterfaces().InstancePerRequest();
            builder.RegisterAssemblyTypes(webAssembly).InstancePerRequest();
            builder.RegisterType<BattleService>().InstancePerRequest();
            builder.RegisterType<BoxerService>().InstancePerRequest();
            builder.RegisterType<BattleProvider>().InstancePerRequest();
            builder.RegisterType<BoxerProvider>().InstancePerRequest();
            builder.RegisterType<MainProvider>().InstancePerRequest();

            builder.RegisterControllers(webAssembly);
            builder.RegisterModule(new AutofacWebTypesModule());
        }
    }
}
