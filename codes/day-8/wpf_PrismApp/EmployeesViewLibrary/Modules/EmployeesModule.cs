using EmployeeServiceLibrary.Services;
using EmployeesViewLibrary.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace EmployeesViewLibrary.Modules
{
    public class EmployeesModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
           
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IEmployeeService, EmployeeService>();
            containerRegistry.RegisterForNavigation<EmployeeRecords>();
        }
    }
}
