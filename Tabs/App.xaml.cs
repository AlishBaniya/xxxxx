﻿using Xamarin.Forms;

namespace Tabs
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // sadad
            MainPage = new NavigationPage(new TabsPage());
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
