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
    public partial class BatterySamplePage : ContentPage
    {
        public BatterySamplePage()
        {
            InitializeComponent();

            BatteryLevel.Text = (Battery.ChargeLevel * 100).ToString() + "%";

            EnergySaver.Text = Battery.EnergySaverStatus.ToString();

            Battery.BatteryInfoChanged += Battery_BatteryInfoChanged;
        }

        private async void Battery_BatteryInfoChanged(object sender, BatteryInfoChangedEventArgs e)
        {
            BatteryLevel.Text = (Battery.ChargeLevel * 100).ToString() + "%";
            await DisplayAlert("BatteryLevel", "Değişti", "Tamam");
        }
    }
}