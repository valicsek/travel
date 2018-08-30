using System;
using System.Collections.Generic;
using SQLite;
using Travel.Model;
using Xamarin.Forms;

namespace Travel
{
    public partial class NewTravelPage : ContentPage
    {
        public NewTravelPage()
        {
            InitializeComponent();
        }

        void OnSaveButtonClicked(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(ExperienceEntry.Text))
            {
                DisplayAlert("Alert", "The experience is empty, please fill it.", "OK");
            }
            else
            {
                try
                {
                    Post post = new Post()
                    {
                        Experience = ExperienceEntry.Text
                    };
                    bool success = BasicModel<Post>.Insert(post);
                    if (success) DisplayAlert("Success", "Experience sucessfully added", "OK");
                }
                catch (SQLiteException ex)
                {
                    string errorMessage = "Something went wrong during adding new Experience \n";
                    errorMessage += ex.Message;
                    DisplayAlert("Failed", errorMessage, "OK");
                }
            }
        }
    }
}
