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
            }
            catch (FeatureNotSupportedException notsuppoertedex)
            {

                throw;
            }
            catch(Exception e)
            {

            }
     
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}