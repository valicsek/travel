using System;
using Travel.ViewModel.Commands;

namespace Travel.ViewModel
{
    public class HomeViewModel: ViewModelBase
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
