using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIwithAutofac
{
    class Program
    {
        private static IContainer Container { get; set; }
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Service>().As<IService>();
            builder.RegisterType<TodayWriter>().As<IDataWriter>();

            Container = builder.Build();

            WriteDate();
        }

        public static void WriteDate()
        {
            // Create the scope, resolve your IDateWriter,
            // use it, then dispose of the scope.
            using (var scope = Container.BeginLifetimeScope())
            {
                var writer = scope.Resolve<IDataWriter>();
                writer.WriteData();
            }
        }
    }
}
