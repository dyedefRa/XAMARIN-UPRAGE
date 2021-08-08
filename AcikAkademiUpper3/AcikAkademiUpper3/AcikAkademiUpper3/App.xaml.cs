using AcikAkademiUpper3.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AcikAkademiUpper3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NotifierPluginPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
