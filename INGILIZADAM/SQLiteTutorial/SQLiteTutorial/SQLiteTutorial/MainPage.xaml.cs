using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SQLiteTutorial
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionview.ItemsSource = await App.myDatabase.GetPeopleAsync();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                await App.myDatabase.SavePersonAsync(new Model.Person()
                {
                    Name = txtName.Text,
                    Subscribed = subscribed.IsChecked
                });
                txtName.Text = string.Empty;
                subscribed.IsChecked = false;

                collectionview.ItemsSource = await App.myDatabase.GetPeopleAsync();
            }
        }
    }
}
