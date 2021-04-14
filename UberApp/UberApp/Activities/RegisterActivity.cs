using Android.App;
using Android.OS;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.CoordinatorLayout.Widget;
using Firebase;
using Firebase.Auth;
using Firebase.Database;
using Google.Android.Material.Snackbar;
using Google.Android.Material.TextField;
using System;
using UberApp.Helper;

namespace UberApp.Activities
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class RegisterActivity : AppCompatActivity
    {
        TextInputLayout txtFullName;
        TextInputLayout txtPhone;
        TextInputLayout txtEmail;
        TextInputLayout txtPassword;
        Button btnRegister;
        CoordinatorLayout rootView;

        FirebaseAuth mAuth;
        FirebaseDatabase database;

        TaskCompletionListener taskCompletionListener = new TaskCompletionListener();


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Register);
            InitializeFirebase();
            mAuth = FirebaseAuth.Instance;
            ConnectControl();
        }

        void ConnectControl()
        {
            txtFullName = (TextInputLayout)FindViewById(Resource.Id.txtFullName);
            txtPhone = (TextInputLayout)FindViewById(Resource.Id.txtPhone);
            txtEmail = (TextInputLayout)FindViewById(Resource.Id.txtEmail);
            txtPassword = (TextInputLayout)FindViewById(Resource.Id.txtPassword);
            btnRegister = (Button)FindViewById(Resource.Id.btnRegister);
            rootView = (CoordinatorLayout)FindViewById(Resource.Id.rootView);

            btnRegister.Click += BtnRegister_Click;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string fullName, phone, email, password;
            fullName = txtFullName.EditText.Text;
            phone = txtPhone.EditText.Text;
            email = txtEmail.EditText.Text;
            password = txtPassword.EditText.Text;

            if (fullName.Length < 3)
            {
                Snackbar.Make(rootView, "Please enter a valid name", Snackbar.LengthLong).Show();
                Toast.MakeText(this, "Please enter a valid name", ToastLength.Short).Show();
                return;
            }
            else if (phone.Length < 9)
            {
                Snackbar.Make(rootView, "Please enter a valid phone number", Snackbar.LengthShort).Show();
                return;
            }
            else if (!email.Contains("@"))
            {
                Snackbar.Make(rootView, "Please enter a valid phone email", Snackbar.LengthShort).Show();
                return;
            }
            else if (password.Length < 8)
            {
                Snackbar.Make(rootView, "Please enter a password upto 8 characters", Snackbar.LengthShort).Show();
                return;
            }

            RegisterUser(fullName, phone, email, password);
        }

        void RegisterUser(string name, string phone, string email, string password)
        {
            taskCompletionListener.Success += TaskCompletionListener_Success;
            taskCompletionListener.Failure += TaskCompletionListener_Failure;
            mAuth.CreateUserWithEmailAndPassword(email, password)
                .AddOnSuccessListener(this, taskCompletionListener)
                .AddOnFailureListener(this, taskCompletionListener);
        }

        private void TaskCompletionListener_Failure(object sender, EventArgs e)
        {
            Snackbar.Make(rootView, "User Registration failed", Snackbar.LengthShort).Show();
        }

        private void TaskCompletionListener_Success(object sender, EventArgs e)
        {
            Snackbar.Make(rootView, "User Registration was Successfull", Snackbar.LengthShort).Show();
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

        //public void OnSuccess(Java.Lang.Object result)
        //{
        //    throw new NotImplementedException();
        //}
    }
}