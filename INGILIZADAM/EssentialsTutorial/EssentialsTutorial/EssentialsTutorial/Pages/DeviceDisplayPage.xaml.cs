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
    public partial class DeviceDisplayPage : ContentPage
    {
        public DeviceDisplayPage()
        {
            InitializeComponent();

            DeviceDisplay.KeepScreenOn = true;
            DeviceDisplay.MainDisplayInfoChanged += DeviceDisplay_MainDisplayInfoChanged;
        }

        private void DeviceDisplay_MainDisplayInfoChanged(object sender, DisplayInfoChangedEventArgs e)
        {
            txtDeviceDisplayLabel.Text = e.DisplayInfo.ToString();
        }
    }
}