using System;
using System.Linq;
using System.Collections.Generic;
using SQLite;
using Travel.Model;
using Xamarin.Forms;
using Travel.ViewModel;

namespace Travel
{
    public partial class HistoryPage : ContentPage
    {
        public HistoryViewModel ViewModel;
        public HistoryPage()
        {
            InitializeComponent();
            this.ViewModel = new HistoryViewModel();
            this.BindingContext = this.ViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            try
            {
                this.ViewModel.GetPosts();
            } catch (SQLiteException ex)
            {
                string errorMessage = "Something went wrong: \n";
                errorMessage += ex.Message;
                DisplayAlert("Alert", errorMessage, "OK");
            }
        }

        void OnHistoryItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
        }
    }
}
