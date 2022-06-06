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
using wpf_Prism_MVVM_Region_Module.Modules;
using wpf_Prism_MVVM_Region_Module.Services;
using wpf_Prism_MVVM_Region_Module.Views;

namespace wpf_Prism_MVVM_Region_Module
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
            containerRegistry.Register<IEmployeeService, EmployeeService>();
            containerRegistry.RegisterForNavigation<EmployeesWindow>();
        }
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule<ShellModule>();
        }
    }
}
