using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace EssentialsTutorial.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScreenShotSamplePage : ContentPage
    {
        public ScreenShotSamplePage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (Screenshot.IsCaptureSupported)
            {
                var result = await Screenshot.CaptureAsync();

                var stream = await result.OpenReadAsync();

                imgResult.Source = ImageSource.FromStream(() => stream);

            }
        }
    }
}