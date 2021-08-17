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
    public partial class CheckConnectPage : ContentPage
    {
        public CheckConnectPage()
        {
            //Sayfa ilk açıldığında internet durumu yazdık ve İnternet yok bilgi ver.
            InitializeComponent();
            txtnetworkState.Text = Connectivity.NetworkAccess.ToString();
            if (Connectivity.NetworkAccess == NetworkAccess.None)
            {
                txtnetworkState.Text = "Please Connect First";
            }

            Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;
        }

        //internet durumu değştiğinde (Uçak modu yada bağlantı koptugunda , 0 dan baglanıldıgında) tetikle
        private void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            txtnetworkState.Text = Connectivity.NetworkAccess.ToString();
            if (e.NetworkAccess == NetworkAccess.None)
            {
                DisplayAlert("Dikkat", "Bağlantı koptu lütfen bağlanın!", "Tamam");
            }
            else if (!e.ConnectionProfiles.Contains(ConnectionProfile.Bluetooth))
            {
                //TO DO Handle Bluetooth
            }
        }
    }
}