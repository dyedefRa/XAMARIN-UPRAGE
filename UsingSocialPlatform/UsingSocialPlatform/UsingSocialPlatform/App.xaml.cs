using System;
using UsingSocialPlatform.ExtensionViews;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UsingSocialPlatform
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PluginPushNotification();
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
