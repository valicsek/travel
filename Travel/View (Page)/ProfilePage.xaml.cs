using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Travel.Model;
using Travel.Services;
using Travel.ViewModel;
using Xamarin.Forms;

namespace Travel
{
    public partial class ProfilePage : ContentPage
    {
        ProfileViewModel ViewModel;
        public ProfilePage()
        {
            InitializeComponent();
            this.ViewModel = new ProfileViewModel();
            this.BindingContext = this.ViewModel;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            try
            {
                this.ViewModel.InProgress = true;
                await this.ViewModel.RequestDataUsingRestService();
            }
            catch (JsonException e)
            {
                string errorMessage = "Something went wrong with data:\n";
                errorMessage += e.Message;
                await DisplayAlert("Alert", errorMessage, "OK");
            }
            catch (Exception e)
            {
                string errorMessage = "Something went wrong:\n";
                errorMessage += e.Message;
                await DisplayAlert("Alert", errorMessage, "OK");
            }
            finally
            {
                this.ViewModel.InProgress = false;
            }
        }
    }
}
