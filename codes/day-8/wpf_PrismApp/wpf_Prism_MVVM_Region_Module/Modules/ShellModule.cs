using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using wpf_Prism_MVVM_Region_Module.Views;

namespace wpf_Prism_MVVM_Region_Module.Modules
{
    public class ShellModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            IRegionManager region = containerProvider.Resolve<IRegionManager>();
            region.RegisterViewWithRegion("EmployeesWindowRegion", typeof(EmployeesWindow));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
