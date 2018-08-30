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

        protected override void OnAppearing()
        {
            base.OnAppearing();
            NavigationPage.SetHasBackButton(this, false);
        }

        void OnAddButtonClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new NewTravelPage());
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}
