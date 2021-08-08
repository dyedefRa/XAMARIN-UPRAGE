
using Plugin.LocalNotifications;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AcikAkademiUpper3.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotifierPluginPage : ContentPage
    {
        public NotifierPluginPage()
        {
            InitializeComponent();
        }

        private void onSend(object sender,EventArgs e)
        {
            string title = txtTitle.Text;
            string message = txtMessage.Text;
            CrossLocalNotifications.Current.Show(title, message);
        }
    }
}