using SQLiteTutorial.Model;
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
        Person lastSelection;
        private void collectionview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lastSelection = (Person)e.CurrentSelection[0];

            txtName.Text = lastSelection.Name;
            subscribed.IsChecked = lastSelection.Subscribed;
        }

        //Update
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            if (lastSelection != null)
            {
                lastSelection.Name = txtName.Text;
                lastSelection.Subscribed = subscribed.IsChecked;
                await App.myDatabase.UpdatePersonAsync(lastSelection);

                collectionview.ItemsSource = await App.myDatabase.GetPeopleAsync();
            }
        }

        //Delete
        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            if (lastSelection != null)
            {
                await App.myDatabase.DeletePersonAsync(lastSelection);
                collectionview.ItemsSource = await App.myDatabase.GetPeopleAsync();

                txtName.Text = string.Empty;
                subscribed.IsChecked = false;
            }
        }

        //Get Subscribed
        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            collectionview.ItemsSource = await App.myDatabase.QuerySubscribedAsync();
        }

        //Get Not Subscribed
        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            collectionview.ItemsSource = await App.myDatabase.LinqNotSubscribedAsync();
        }
    }
}
