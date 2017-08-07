using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamFormsNativePages
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //The root page of the application
            MainPage = new MainPage();
            ((MainPage)MainPage).ButtonPressed += MainPageButtonPressed;
        }

        private void MainPageButtonPressed(object sender, EventArgs e)
        {
            MainPage page = MainPage as MainPage;
            page.RandomNumber = new Random().Next();
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
