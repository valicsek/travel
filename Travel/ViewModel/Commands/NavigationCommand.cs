﻿using System;
using System.Windows.Input;

namespace Travel.ViewModel.Commands
{
    public class NavigationCommand : ICommand
    {
        public NavigationCommand()
        {
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
