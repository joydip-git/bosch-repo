//using EmployeeServiceLibrary.Services;
using EmployeesUI.Modules;
using EmployeesUI.Views;
using EmployeesViewLibrary.Modules;
//using EmployeesViewLibrary.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace EmployeesUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.RegisterForNavigation<EmployeeRecords>();
            //containerRegistry.Register<IEmployeeService, EmployeeService>();
        }
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule<EmployeesModule>();
            moduleCatalog.AddModule<ShellModule>();
        }
    }
}
