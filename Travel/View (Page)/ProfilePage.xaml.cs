using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Travel.Model;
using Travel.Services;
using Xamarin.Forms;

namespace Travel
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            LoadingIndicator.IsRunning = true;
            try
            {
                List<Data> result = await RestService<Data>.GetAsyncRequest(Config.exampleProfileApiRequest);
                List<Data> users = result.FindAll((obj) => obj.First_name.ToLower().Contains("g"));

                if (users.Count > 0)
                {
                    await DisplayAlert("First name", users[0].First_name, "OK");
                }
            } catch (JsonException e)
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
                LoadingIndicator.IsRunning = false;
            }
        }
    }
}
