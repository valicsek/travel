using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Travel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnButtonLogInClicked(object sender, System.EventArgs e)
        {
            if ( !string.IsNullOrEmpty(UsernameEntry.Text) && !string.IsNullOrEmpty(PasswordEntry.Text))
            {
                if( UsernameEntry.Text == "test")
                {
                    Navigation.PushAsync(new HomePage());
                }
                else
                {
                    DisplayAlert("Alert", "Username or password is not correct!", "OK");
                }
            }
            else
            {
                DisplayAlert("Alert", "Username or password is missing!", "OK");
            }
        }
    }
}
