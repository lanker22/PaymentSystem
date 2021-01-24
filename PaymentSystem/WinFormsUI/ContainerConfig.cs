using Autofac;
using ClassLibrary;

namespace WinFormsUI
{
    public static class ContainerConfig
    {
        
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Account>().As<IAccount>();
            builder.RegisterType<Customer>().As<ICustomer>();


            return builder.Build();
        }
    }
}
