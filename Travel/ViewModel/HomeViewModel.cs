using System;
using Travel.ViewModel.Commands;

namespace Travel.ViewModel
{
    public class HomeViewModel
    {
        public NavigationCommand navigationCommand;

        public HomeViewModel()
        {
            this.navigationCommand = new NavigationCommand();
        }

        public void Navigate()
        {

        }
    }
}
