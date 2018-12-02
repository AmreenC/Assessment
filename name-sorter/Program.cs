using Autofac;
using Serilog;
using System;

namespace name_sorter
{
    public class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var sort = scope.Resolve<ISort>();
                sort.Run(args[0]);
            }

            Console.ReadLine();
        }
    }
}
