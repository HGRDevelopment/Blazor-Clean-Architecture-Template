using Autofac;
using HGR.Application.Abstractions;
using HGR.Infrastructure.Repositories;

namespace HGR.WebAPI.Modules
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            ConfigureRepositories(builder);
        }

        private static void ConfigureRepositories(ContainerBuilder builder)
        {
            builder.RegisterType<DummyRepository>().As<IDummyRepository>().InstancePerLifetimeScope();

        }
    }
}
