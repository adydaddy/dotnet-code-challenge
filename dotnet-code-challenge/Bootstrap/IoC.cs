using System.Reflection;
using Autofac;

namespace dotnet_code_challenge.Bootstrap
{
    public static class IoC
    {
        public static IContainer Container { get; set; }

        public static void RegisterIoC()
        {
            ContainerBuilder builder = new ContainerBuilder();
            var currentAssembly = Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(currentAssembly)
                .AsImplementedInterfaces();

            Container = builder.Build();
        }

        public static T Resolve<T>()
        {
            using (var scope = Container.BeginLifetimeScope())
            {
                return scope.Resolve<T>();
            }
        }
    }
}
