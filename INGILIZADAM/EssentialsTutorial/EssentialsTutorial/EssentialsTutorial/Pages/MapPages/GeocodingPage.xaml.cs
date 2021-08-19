using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EssentialsTutorial.Pages.MapPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeocodingPage : ContentPage
    {
        public GeocodingPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var result = await Geocoding.GetLocationsAsync(txtEntry.Text);
                if (result.Any())
                {
                    lblResult.Text = $"lat: {result.FirstOrDefault()?.Latitude} , long: {result.FirstOrDefault()?.Longitude}";
                }
            }
            catch (FeatureNotSupportedException notsuppoertedex)
            {

                throw;
            }
        

        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                double lat;
                double lng;
                lat = Convert.ToDouble(txtEntry.Text.Split(',')[0]);
                lng = Convert.ToDouble(txtEntry.Text.Split(',')[1]);

                var result = await Geocoding.GetPlacemarksAsync(lat,lng);
                if (result.Any())
                {
                    lblResult.Text = result.FirstOrDefault()?.FeatureName;
                }
            }
            catch (FeatureNotSupportedException notsuppoertedex)
            {

                throw;
            }
          
        }
    }
}