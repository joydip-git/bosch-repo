using Prism.Commands;
using Prism.Mvvm;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using wpf_Prism_MVVM_Region_Module.Models;
using wpf_Prism_MVVM_Region_Module.Services;

namespace wpf_Prism_MVVM_Region_Module.ViewModels
{
    public class EmployeesWindowViewModel : BindableBase
    {
        private IEmployeeService _employeeService = null;

        public EmployeesWindowViewModel(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }


        public ObservableCollection<Employee> Employees { get; private set; } = new ObservableCollection<Employee>();


        private Employee _selectedEmployee = null;
        public Employee SelectedEmployee
        {
            get => _selectedEmployee;
            set
            {
                if (SetProperty<Employee>(ref _selectedEmployee, value))
                {
                    Debug.WriteLine(_selectedEmployee.Name ?? "no customer selected");
                }
            }
        }

        private DelegateCommand _commandLoad = null;
        public DelegateCommand CommandLoad =>
            _commandLoad ?? (_commandLoad = new DelegateCommand(CommandLoadExecute, CanExecute));

        private void CommandLoadExecute()
        {
            Employees.Clear();
            List<Employee> list = _employeeService.GetAll();
            foreach (Employee item in list)
            {
                Employees.Add(item);
            }
        }
        private bool CanExecute()
        {
            return true;
        }
    }
}
