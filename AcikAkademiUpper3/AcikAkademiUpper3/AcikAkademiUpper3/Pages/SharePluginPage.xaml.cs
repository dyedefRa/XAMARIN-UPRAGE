using Plugin.Share;
using Plugin.Share.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AcikAkademiUpper3.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SharePluginPage : ContentPage
    {
        public SharePluginPage()
        {
            InitializeComponent();
        }

        private void onShare(object sender, EventArgs e)
        {
       
            string title = txtTitle.Text;
            string message = txtMessage.Text;
            string url = txtUrl.Text;

            if (string.IsNullOrEmpty(url))
            {
                url= "https://www.google.com.tr/";
            }
            ShareMessage shareMessage = new ShareMessage();
            shareMessage.Title = title;
            shareMessage.Text = message;
            shareMessage.Url = url;
            //Hangi uygulamada paylaşmak istiyorsun.
            //CrossShare.Current.Share(shareMessage);

            //Browser aç.
            CrossShare.Current.OpenBrowser(
                url,
                new BrowserOptions()
                {
                    ChromeShowTitle = true
                });
        }

        private void onCopy(object sender,EventArgs e)
        {
            if (CrossShare.Current.SupportsClipboard)
            {
                CrossShare.Current.SetClipboardText(txtTitle.Text);
                DisplayAlert(txtTitle.Text, " kopyalandı","Tamam");
            }
        }
    }
}