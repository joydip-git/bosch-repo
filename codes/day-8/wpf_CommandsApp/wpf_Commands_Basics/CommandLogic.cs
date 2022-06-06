using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace wpf_Commands_Basics
{
    class CommandLogic : ICommand
    {
        private Action<object> _execute;
        private Predicate<object> _canExecute;
        public CommandLogic()
        {

        }
        public CommandLogic(Action<object> execute, Predicate<object> canExecute) : this()
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
        public bool CanExecute(object parameter)
        {
            return _canExecute(parameter);
        }

        public event EventHandler CanExecuteChanged;
        //CommandManager
        //{
        //    add { CommandManager.RequerySuggested += value; }
        //    remove { CommandManager.RequerySuggested -= value; }
        //}
    }
}
