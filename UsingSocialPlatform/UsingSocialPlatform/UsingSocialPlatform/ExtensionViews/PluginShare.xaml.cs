using Plugin.Share;
using Plugin.Share.Abstractions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UsingSocialPlatform.ExtensionViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PluginShare : ContentPage
    {
        public PluginShare()
        {
            InitializeComponent();
            this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            string title = txtTitle.Text;
            string message = txtMessage.Text;
            string url = txtUrl.Text;
            if (string.IsNullOrEmpty(url))
                url = "https://www.google.com";

            ShareMessage shareMessage = new ShareMessage()
            {
                Text = message,
                Title = title,
                Url = url
            };
            //CrossShare.Current.Share(shareMessage);
            CrossShare.Current.Share(shareMessage);

        }
    }
}