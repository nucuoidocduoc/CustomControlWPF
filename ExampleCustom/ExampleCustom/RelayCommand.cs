using System;
using System.Windows.Input;

namespace ExampleCustom
{
    public class RelayCommand<T> : ICommand
    {
        private readonly Action<T> _action;

        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action<T> action)
        {
            _action = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action.Invoke((T)parameter);
        }
    }
}