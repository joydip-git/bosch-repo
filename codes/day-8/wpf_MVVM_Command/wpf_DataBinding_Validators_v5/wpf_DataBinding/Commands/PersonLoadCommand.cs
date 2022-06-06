using System;
using System.Windows.Input;

namespace wpf_DataBinding.Commands
{
    public class PersonLoadCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Predicate<object> _canEexcute;

        public PersonLoadCommand()
        {

        }

        public PersonLoadCommand(Action<object> execute, Predicate<object> canExecute) : this()
        {
            _execute = execute;
            _canEexcute = canExecute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return _canEexcute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
