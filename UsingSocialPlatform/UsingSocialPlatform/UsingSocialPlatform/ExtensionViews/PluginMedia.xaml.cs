
using Plugin.Media;
using Plugin.Media.Abstractions;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UsingSocialPlatform.ExtensionViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PluginMedia : ContentPage
    {
        public PluginMedia()
        {
            InitializeComponent();
        }

        private  void btnTakePhoto_Clicked(object sender, System.EventArgs e)
        {
            if (!CrossMedia.Current.IsCameraAvailable ||
                !CrossMedia.Current.IsTakePhotoSupported)
            {
                DisplayAlert("Hata", "Kamera Kullanılamıyor!", "Tamam");
                return;
            }

            var file =  CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions()
            {
                Directory = "Sample",
                Name = "photo.jpg"
            });
            if (file == null)
                return;

            imgShown.Source = ImageSource.FromStream(() =>
            {
                var stream = file.Result.GetStream();
                file.Dispose();
                return stream;
            });

        }

        private void btnPickPhoto_Clicked(object sender, System.EventArgs e)
        {
            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                DisplayAlert("Hata", "Fotoğraf seçilemedi!", "Tamam");
                return;
            }

            var file = CrossMedia.Current.PickPhotoAsync();

            imgShown.Source = ImageSource.FromStream(() =>
            {
                var stream = file.Result.GetStream();
                file.Dispose();
                return stream;
            });

        }

        private void btnTakeVideo_Clicked(object sender, System.EventArgs e)
        {
            if (!CrossMedia.Current.IsCameraAvailable||
                !CrossMedia.Current.IsTakeVideoSupported)
            {
                DisplayAlert("Hata", "Video çekilemedi!", "Tamam");
                return;
            }
        }

        private void btnPickVideo_Clicked(object sender, System.EventArgs e)
        {

        }
    }
}