using Plugin.Media;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AcikAkademiUpper3.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MediaPluginPage : ContentPage
    {
        public MediaPluginPage()
        {
            InitializeComponent();
        }

        //HATA VAR BURADA
        private async void onTakePhoto(object sender, EventArgs e)
        {
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                DisplayAlert("Hata", "Kamera kullanılamıyor!", "Tamam");
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions()
            {
                Directory = "Sample",
                Name = "photo.jpg"
            });

            if (file == null)
                return;

            image.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                file.Dispose();
                return stream;
            });

        }
    }
}