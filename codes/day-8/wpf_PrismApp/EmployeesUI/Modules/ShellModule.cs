using EmployeesViewLibrary.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace EmployeesUI.Modules
{
    public class ShellModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            IRegionManager region = containerProvider.Resolve<IRegionManager>();
            region.RegisterViewWithRegion("EmployeesWindowRegion", typeof(EmployeeRecords));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
