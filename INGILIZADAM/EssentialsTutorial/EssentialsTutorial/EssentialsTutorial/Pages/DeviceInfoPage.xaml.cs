using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EssentialsTutorial.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeviceInfoPage : ContentPage
    {
        public DeviceInfoPage()
        {
            InitializeComponent();

            DeviceType.Text = DeviceInfo.DeviceType.ToString();
            Model.Text = DeviceInfo.Model;
            Manufacturer.Text = DeviceInfo.Manufacturer;
            Name.Text = DeviceInfo.Name;
            Version.Text = DeviceInfo.VersionString;
            Platform.Text = DeviceInfo.Platform.ToString() ;
        }
    }
}