using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Travel
{
    public partial class HomePage : TabbedPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        void OnAddButtonClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new NewTravelPage());
        }
    }
}
