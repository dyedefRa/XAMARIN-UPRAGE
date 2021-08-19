using EssentialsTutorial.Pages;
using EssentialsTutorial.Pages.MapPages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EssentialsTutorial
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PickImagesAndPDFPage();
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
