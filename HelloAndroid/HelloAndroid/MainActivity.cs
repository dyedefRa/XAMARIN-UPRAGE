using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using HelloAndroid.Extension;
using HelloAndroid.Models;
using System.Collections.Generic;

namespace HelloAndroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText txtUsername;
        EditText txtPassword;
        Button btnLogin;

        public static List<Student> students = new List<Student>();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            txtUsername = FindViewById<EditText>(Resource.Id.txtUserName);
            txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);
            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);

            btnLogin.Click += BtnLogin_Click;
        }

        private void BtnLogin_Click(object sender, System.EventArgs e)
        {
            //Toast.MakeText(this, txtUsername.Text, ToastLength.Short).Show();

            //StartActivity(typeof(LoginActivity));

            var intent = new Intent(this, typeof(LoginActivity));
            Student student = new Student()
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text
            };
            //intent.PutExtra("relatedStudent",JsonConvert.SerializeObject(student));
            intent.PutExtra("relatedStudent", student.ToJson());

            StartActivity(intent);

           
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}