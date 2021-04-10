using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.TextField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Firebase.Auth;
using Firebase.Database;
using Firebase;

namespace UberApp.Activities
{
    [Activity(Label = "@string/app_name",MainLauncher =true)]
    public class RegisterActivity : AppCompatActivity
    {
        TextInputLayout txtFullName;
        TextInputLayout txtPhone;
        TextInputLayout txtEmail;
        TextInputLayout txtPassword;
        Button btnRegister;

        FirebaseAuth mAuth;
        FirebaseDatabase database;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Register);
            InitializeFirebase();
            mAuth = FirebaseAuth.Instance;
        }

        void ConnectControl()
        {
            txtFullName = (TextInputLayout)FindViewById(Resource.Id.txtFullName);
            txtPhone = (TextInputLayout)FindViewById(Resource.Id.txtPhone);
            txtEmail = (TextInputLayout)FindViewById(Resource.Id.emailText);
            txtPassword = (TextInputLayout)FindViewById(Resource.Id.passwordText);
            btnRegister = (Button)FindViewById(Resource.Id.btnRegister);
        }

        public static void InitializeFirebase()
        {
            FirebaseDatabase database;
            var app = FirebaseApp.InitializeApp(Application.Context);
            if (app == null)
            {
                var options = new FirebaseOptions.Builder()
                    .SetApplicationId("uberapp-56725")
                    .SetApiKey("AIzaSyAmZzmZD9EXFvqruksdNSHPYH6VV1e6uxw")
                     .SetDatabaseUrl("https://uberapp-56725-default-rtdb.firebaseio.com/")
                    .SetStorageBucket("uberapp-56725.appspot.com")
                    .Build();

                app = FirebaseApp.InitializeApp(Application.Context, options);
            }
            database = FirebaseDatabase.GetInstance(app);



        //    DatabaseReference dbref = database.GetReference("UserSupport");
        //    dbref.SetValue("Ticket1");

        //    Toast.MakeText(Application.Context, "Completed", ToastLength.Short).Show();
        }

    }
}