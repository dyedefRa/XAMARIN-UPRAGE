using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.CoordinatorLayout.Widget;
using Firebase;
using Firebase.Auth;
using Google.Android.Material.Snackbar;
using Google.Android.Material.TextField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UberApp.Helper;

namespace UberApp.Activities
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class LoginActivity : AppCompatActivity
    {
        TextInputLayout txtEmail;
        TextInputLayout txtPassword;
        Button btnLogin;
        CoordinatorLayout rootView;
        FirebaseAuth mAuth;

        TextView clickToRegister;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Login);
            // Create your application here
            txtEmail = (TextInputLayout)FindViewById(Resource.Id.emailText);
            txtPassword = (TextInputLayout)FindViewById(Resource.Id.passwordText);
            btnLogin = (Button)FindViewById(Resource.Id.btnLogin);
            clickToRegister = (TextView)FindViewById(Resource.Id.clickToRegisterText);
            rootView = (CoordinatorLayout)FindViewById(Resource.Id.rootViewLogin);
            InitializeFirebase();

            btnLogin.Click += BtnLogin_Click;
            clickToRegister.Click += ClickToRegister_Click;
        }

        private void ClickToRegister_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(RegisterActivity));
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email, password;

            email = txtEmail.EditText.Text;
            password = txtPassword.EditText.Text;

            if (!email.Contains("@"))
            {
                Snackbar.Make(rootView, "Please provide a valid email", Snackbar.LengthShort).Show();
                return;
            }
            else if (password.Length < 8)
            {
                Snackbar.Make(rootView, "Please provide a valid password", Snackbar.LengthShort).Show();
                return;
            }

            TaskCompletionListener taskCompletionListener = new TaskCompletionListener();
            taskCompletionListener.Success += TaskCompletionListener_Success;
            taskCompletionListener.Failure += TaskCompletionListener_Failure;

            mAuth.SignInWithEmailAndPassword(email, password)
                .AddOnSuccessListener(taskCompletionListener)
                .AddOnFailureListener(taskCompletionListener);


        }

        private void TaskCompletionListener_Failure(object sender, EventArgs e)
        {
            Snackbar.Make(rootView, "Login Failed", Snackbar.LengthShort).Show();
        }

        private void TaskCompletionListener_Success(object sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));
        }

        void InitializeFirebase()
        {
            var app = FirebaseApp.InitializeApp(this);
            if (app == null)
            {
                var options = new FirebaseOptions.Builder()
                    .SetApplicationId("uberapp-56725")
                    .SetApiKey("AIzaSyAmZzmZD9EXFvqruksdNSHPYH6VV1e6uxw")
                     .SetDatabaseUrl("https://uberapp-56725-default-rtdb.firebaseio.com/")
                    .SetStorageBucket("uberapp-56725.appspot.com")
                    .Build();
                app = FirebaseApp.InitializeApp(this, options);           
            }
         
            mAuth = FirebaseAuth.Instance;
        }
      
    }
}