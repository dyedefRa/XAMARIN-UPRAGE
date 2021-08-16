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
    public partial class PreferenceSamplePage : ContentPage
    {
        public PreferenceSamplePage()
        {
            InitializeComponent();

            txtRandom.Text = Preferences.Get("textRandom",string.Empty);
            swtchRandom.IsToggled = Preferences.Get("switchRandom", false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Preferences.Set("textRandom", txtRandom.Text);
            Preferences.Set("switchRandom", swtchRandom.IsToggled);
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Preferences.Clear();
        }
    }
}