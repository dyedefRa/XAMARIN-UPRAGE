using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AcikAkademiUpper3.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MediaPickerPage : ContentPage
    {
        public MediaPickerPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (MediaPicker.IsCaptureSupported)
            {
                var result = await MediaPicker.PickPhotoAsync(new MediaPickerOptions()
                {
                    Title = "Please pick a photo",
                });

                if (result!=null)
                {
                    var stream = await result.OpenReadAsync();
                    resultImage.Source = ImageSource.FromStream(() => stream);
                }             
            }
        }

        //Take Phooto
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var result = await MediaPicker.CapturePhotoAsync();

            if (result!=null)
            {
                var stream = await result.OpenReadAsync();
                resultImage.Source = ImageSource.FromStream(() => stream);
            }
          
        }
    }
}