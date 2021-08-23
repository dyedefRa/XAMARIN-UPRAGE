using BertBoschTutorials.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BertBoschTutorials.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            lblUserName.TextColor = Constants.MainTextColor;
            lblPassword.TextColor = Constants.MainTextColor;
            activitySpinner.IsVisible = false;
            LoginIcon.HeightRequest = Constants.LoginIconHeight;

            txtUserName.Completed += (s, e) => txtPassword.Focus();
            txtPassword.Completed += (s, e) => btnSignIn_Clicked(s, e);
        }

        private void btnSignIn_Clicked(object sender, EventArgs e)
        {
            User user = new User(txtUserName.Text, txtPassword.Text);
            if (user.CheckInformation())
            {
                DisplayAlert("Login", "Login Success", "Okey");
                App.UserDatabase.SaveUser(user);
            }
            else
                DisplayAlert("Login", "Login Not Correct,empty username or password", "Okey");

        }
    }
}