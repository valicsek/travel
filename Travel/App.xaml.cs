﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Travel
{
    public partial class App : Application
    {
        public static string DatabaseLocation = string.Empty;
        public App()
        {
            InitializeComponent();

            MainPage mainPage = new MainPage();
            NavigationPage.SetHasNavigationBar(mainPage, false);

            MainPage = new NavigationPage(mainPage);
        }

        public App(string databaseLocation)
        {
            InitializeComponent();
            DatabaseLocation = databaseLocation;

            MainPage mainPage = new MainPage();
            NavigationPage.SetHasNavigationBar(mainPage, false);
            MainPage = new NavigationPage(mainPage);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
