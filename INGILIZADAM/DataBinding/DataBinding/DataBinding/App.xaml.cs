using DataBinding.Pages;
using DataBinding.Pages.Sample1;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBinding
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Sample1Page();
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
