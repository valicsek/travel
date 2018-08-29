using System;
using System.Linq;
using System.Collections.Generic;
using SQLite;
using Travel.Model;
using Xamarin.Forms;

namespace Travel
{
    public partial class HistoryPage : ContentPage
    {
        public HistoryPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            try
            {
                using(SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
                {
                    conn.CreateTable<Post>();
                    var posts = conn.Table<Post>().ToList();
                }
            } catch (SQLiteException ex)
            {
                string errorMessage = "Something went wrong: \n";
                errorMessage += ex.Message;
                DisplayAlert("Alert", errorMessage, "OK");
            }
        }
    }
}
