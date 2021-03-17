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
            Content = webView;
        }
    }
}