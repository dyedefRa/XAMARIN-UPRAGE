using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.CommunityToolkit.Extensions;

namespace Popup
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var popupResult = new MyPopupResult()
            {
                ReturnData = "Initial Data"
            };
            var result = await Navigation.ShowPopupAsync(new MyPopup(popupResult));
            await DisplayAlert("Result", $"Result : {result.ReturnData}", "OK");
        }
    }
}
