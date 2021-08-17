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
    public partial class ShakeMovementPage : ContentPage
    {
        public ShakeMovementPage()
        {
            InitializeComponent();
            Accelerometer.ReadingChanged += Accelerometer_ReadingChanged;
        }

        private void Accelerometer_ReadingChanged(object sender, AccelerometerChangedEventArgs e)
        {
            txtResultX.Text =$"X: {e.Reading.Acceleration.X}";
            txtResultY.Text = $"Y: {e.Reading.Acceleration.Y}";
            txtResultZ.Text = $"Z: {e.Reading.Acceleration.Z}";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (Accelerometer.IsMonitoring)
                Accelerometer.Stop();
            else
                Accelerometer.Start(SensorSpeed.UI);

        }
    }
}