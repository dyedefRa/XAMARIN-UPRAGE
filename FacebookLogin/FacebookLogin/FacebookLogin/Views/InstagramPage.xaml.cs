using FacebookLogin.Models;
using FacebookLogin.Provider;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FacebookLogin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InstagramPage : ContentPage
    {
        private readonly IList<Item> model =
            new ObservableCollection<Item>();

        public InstagramPage()
        {
            InitializeComponent();
            GetProfile();
            BindingContext = model;
        }

        private async void GetProfile()
        {
            ServiceManager<InstagramProfile> manager = new ServiceManager<InstagramProfile>();

            var profile =await manager.Get("https://www.instagram.com/microsoft/media");

            foreach (var item in profile.items)
            {
                model.Add(item);
            }
        }
    }
}