using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Popup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyPopup : Xamarin.CommunityToolkit.UI.Views.Popup<MyPopupResult>
    {
        private MyPopupResult _result;
        public MyPopup(MyPopupResult result)
        {
            InitializeComponent();
            _result = result;
            lblName.Text = _result.ReturnData;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            _result.ReturnData = "Return Data From Popup";
            Dismiss(_result);
        }
    }
}