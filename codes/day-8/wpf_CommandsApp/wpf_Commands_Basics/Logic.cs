using System;
using System.Windows;

namespace wpf_Commands_Basics
{
    class Logic
    {
        private Action<object> _execute;
        private Predicate<object> _canExecute;

        public Logic()
        {
            _execute = new Action<object>(this.SayHi);
            _canExecute = new Predicate<object>(this.CanCallMethod);

            CommandLogic = new CommandLogic(this._execute, this._canExecute);
        }

        public bool IsEnabled { set; get; } = false;
        //private bool _isEnabled;

        public CommandLogic CommandLogic { private set; get; }

        private void SayHi(object parameter)
        {
            IsEnabled = (bool)parameter;
            MessageBox.Show(parameter.ToString());
        }
        public bool CanCallMethod(object parameter)
        {
            MessageBox.Show($"called:{IsEnabled}");
            //return true;
            if (IsEnabled)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
