using Plugin.LocalNotifications;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UsingSocialPlatform.ExtensionViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PluginPushNotification : ContentPage
    {
        public PluginPushNotification()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string message = txtMessage.Text;
            CrossLocalNotifications.Current.Show(title, message);
        }
    }
}