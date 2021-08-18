using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EssentialsTutorial.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsSamplePage : ContentPage
    {
        public ContactsSamplePage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //var rs = await Contacts.GetAllAsync();
            var result = await Contacts.PickContactAsync();

            if (result != null)
            {
                txtResultContact.Text = $" {result.DisplayName} ({result.Phones[0].PhoneNumber})";
            }
        }
    }
}