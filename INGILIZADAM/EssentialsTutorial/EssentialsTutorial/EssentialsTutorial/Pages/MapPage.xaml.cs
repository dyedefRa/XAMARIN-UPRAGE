using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EssentialsTutorial.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        Location myLocation;
        public MapPage()
        {
            InitializeComponent();
            myLocation = new Location(40.646448, 29.121460);
        }

        //OpenMap
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Map.OpenAsync(myLocation);
        }
        //Directions
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            MapLaunchOptions mapLaunchOptions = new MapLaunchOptions()
            {
                Name = "Test Name",
                NavigationMode = NavigationMode.Driving
            };

            await Map.OpenAsync(myLocation, mapLaunchOptions);
        }
        //Placemarks
        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            Placemark placemark = new Placemark()
            {
                Location = new Location(40.648247, 29.126787)
            };
            await placemark.OpenMapsAsync();
        }
    }
}