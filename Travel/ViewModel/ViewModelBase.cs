using System;
using Travel.Model;

namespace Travel.ViewModel
{
    public abstract class ViewModelBase : Bindable
    {
        protected bool inProgress;
        public bool InProgress
        {
            get => inProgress;
            set => SetField<bool>(ref inProgress, value);
        }
    }
}
