using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using HelloAndroid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloAndroid
{
    [Activity(Label = "InsertActivity")]
    public class InsertActivity : Activity
    {
        EditText txtUsername;
        EditText txtPassword;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.InsertPage);

            txtUsername = FindViewById<EditText>(Resource.Id.txtUser);
            txtPassword = FindViewById<EditText>(Resource.Id.txtPass);

            Button btnInsert = FindViewById<Button>(Resource.Id.btnInsert);
            Button btnListpage = FindViewById<Button>(Resource.Id.btnGoToList);

            btnInsert.Click += BtnInsert_Click;
            btnListpage.Click += BtnListpage_Click1;
            // Create your application here
            //btnListpage.Click += BtnListpage_Click;
        }

        private void BtnListpage_Click1(object sender, EventArgs e)
        {
            StartActivity(typeof(ListPageActivity));
        }

   

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                Toast.MakeText(this, "Boş olmamalı!", ToastLength.Short).Show();
                return;
            }
            MainActivity.students.Add(new Student()
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text.ToString()
            });
            Toast.MakeText(this, txtUsername.Text + " eklendi.", ToastLength.Short).Show();
            txtUsername.Text = "";
            txtPassword.Text = "";

        }
    }
}