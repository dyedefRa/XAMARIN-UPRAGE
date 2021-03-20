using FacebookLogin.Models;
using FacebookLogin.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FacebookLogin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacebookPage : ContentPage
    {
        //string url = "https://www.facebook.com/dialog/oauth?client_id=496961464650517&redirect_uri=https://www.facebook.com/connect/login_success.html";

        private string FacebookClientId = "496961464650517";
        private string FacebookStatic = "https://www.facebook.com/connect/login_success.html";

        public FacebookPage()
        {
            InitializeComponent();
            this.BackgroundColor = Color.White;

            string apiRequest = "https://www.facebook.com/dialog/oauth?client_id="
               + FacebookClientId
               + "&display=popup&response_type=token&redirect_uri="
               + FacebookStatic;

            var webView = new WebView
            {
                Source = apiRequest,
                HeightRequest = 1
            };

            webView.Navigated += WebView_Navigated;
            Content = webView;
        }

        private async void WebView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            var accessToken = UrldenAccessTokenCozucu(e.Url);
            if (!String.IsNullOrEmpty(accessToken))
            {
                ServiceManager<FacebookProfile> manager = new ServiceManager<FacebookProfile>();
                var profile = await manager.GetFacebookProfile(accessToken);
                SetFacebookProfileonXamarinPage(profile);
            }
        }

        //AccesToken dönuyor
        private string UrldenAccessTokenCozucu(string url)
        {
            if (url.Contains("access_token") && url.Contains("&expires_in="))
            {
                var http = "https";
          
                if (Xamarin.Forms.Device.RuntimePlatform == Xamarin.Forms.Device.UWP || Xamarin.Forms.Device.RuntimePlatform == Xamarin.Forms.Device.WPF)
                    http = "http";

                url = url.Replace(http + "://www.facebook.com/connect/login_success.html#access_token=", "");
                var accessToken = url.Remove(url.IndexOf("&expires_in="));
                return accessToken;
            }

            return "";
        }

        private void SetFacebookProfileonXamarinPage(FacebookProfile profile)
        {
            string url = "https://graph.facebook.com/" + profile.Id + "/picture?width=450&height=450";
            Uri facebookUri = new Uri(url);

            Image profilePictureImage = new Image()
            {
                Source = ImageSource.FromUri(facebookUri)
            };

            Label lblName = new Label
            {
                Text = profile.Name,
                FontSize = 24,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Black
            };

            StackLayout layout = new StackLayout
            {
                Padding = 10,
                Spacing = 10,
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    profilePictureImage,
                    lblName
                }
            };
            Content = layout;
        }
    }
}