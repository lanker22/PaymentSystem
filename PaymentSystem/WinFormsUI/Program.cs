using Autofac;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = ContainerConfig.Configure();
            using var scope = container.BeginLifetimeScope();
            var account = scope.Resolve<IAccount>();
            var customer = scope.Resolve<ICustomer>();
            Start(customer);
        }

        static void Start(ICustomer customer)
        {
            MessageBox.Show("Starting");
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashboard(customer));
        }
    }
}
