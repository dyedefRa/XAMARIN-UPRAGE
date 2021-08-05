using Plugin.Geolocator;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace AcikAkademiDersleri
{
    public class MapPage : ContentPage
    {
        private double Latitude;
        private double Longitude;

        public MapPage()
        {
            //Basit olarak oluşturdugumuz method
            // CreateMap();

            CreateMap();
        }

        private void CreateMap()
        {
            GetLocationWithGeolocator();
            Xamarin.Forms.Maps.Map currentMap = new Xamarin.Forms.Maps.Map()
            {
                HasScrollEnabled = true,
                HasZoomEnabled = true,
                MapType = MapType.Street
            };

            currentMap.MoveToRegion(
                MapSpan.FromCenterAndRadius(
                   new Position(Latitude, Longitude),
                   Distance.FromMeters(300))
                    );
            //Pin
            Pin microsoftPin = new Pin()
            {
                Type = PinType.Place,
                Address = "Test İstanbul",
                Label = "MS Turkey",
                Position = new Position(41.0707118, 29.0154514)
            };
            microsoftPin.Clicked += MicrosoftPin_Clicked;

            Pin testPini = new Pin()
            {
                Type = PinType.SavedPin,
                Address = "Test Pin Addres",
                Label = "Test Pin Label",
                Position = new Position(41.0703419, 29.0158065)
            };
            testPini.Clicked += MicrosoftPin_Clicked;

            currentMap.Pins.Add(microsoftPin);
            currentMap.Pins.Add(testPini);

            Content = currentMap;
        }

        private void MicrosoftPin_Clicked(object sender, EventArgs e)
        {
            Pin selectedPin = (Pin)sender;
            DisplayAlert(selectedPin.Label, selectedPin.Address, "Ok");
        }


        private async void GetLocationWithGeolocator()
        {
            if (CrossGeolocator.Current.IsGeolocationAvailable)
            {
                //Burası pluginin readme dosyasında yazıyor.
                var locator = CrossGeolocator.Current;
                locator.DesiredAccuracy = 50;

                var positon = await locator.GetPositionAsync(TimeSpan.FromSeconds(20));

                Latitude = positon.Latitude;
                Longitude = positon.Longitude;
            }
           

        }

 
    }

}
