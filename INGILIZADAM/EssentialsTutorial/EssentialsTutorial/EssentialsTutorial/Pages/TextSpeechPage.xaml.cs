using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace EssentialsTutorial.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TextSpeechPage : ContentPage
    {
        public TextSpeechPage()
        {
            InitializeComponent();
        }

        IEnumerable<Locale> locales;

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            //Tüm dilleri locales listesine attık
            locales = await TextToSpeech.GetLocalesAsync();
            //listedeki diileri pcker a attık
            foreach (var item in locales)
            {
                pckLanguages.Items.Add(item.Name);
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (pckLanguages.SelectedIndex > 0 && !string.IsNullOrEmpty(txtTexttoSpeech.Text))
            {
                await TextToSpeech.SpeakAsync(txtTexttoSpeech.Text,
                     new SpeechOptions
                     {
                         Locale = locales.Single(x => x.Name == pckLanguages.SelectedItem.ToString())
                     });
            }
        }
    }
}