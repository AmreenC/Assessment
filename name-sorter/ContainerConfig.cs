using Autofac;
using name_sorter.Services;

namespace name_sorter
{
    public class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<FileService>().As<IFileService>();
            builder.RegisterType<RenameService>().As<IRenameService>();
            builder.RegisterType<SortingService>().As<ISortingService>();
            builder.RegisterType<Sort>().As<ISort>();

            return builder.Build();
        }
    }
}
