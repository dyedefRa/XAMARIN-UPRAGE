using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace UberApp.Activities
{
    [Activity(Label = "@string/app_name", MainLauncher = true, NoHistory = false, ScreenOrientation =Android.Content.PM.ScreenOrientation.Portrait)]
    public class SplashActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            //Thread.Sleep(2000);
        }

        protected override void OnResume()
        {
            base.OnResume();
            StartActivity(typeof(LoginActivity));
        }
    }
}