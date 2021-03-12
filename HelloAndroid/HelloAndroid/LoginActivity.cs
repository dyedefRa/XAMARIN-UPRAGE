using Android.App;
using Android.OS;
using Android.Widget;
using HelloAndroid.Extension;
using HelloAndroid.Models;

namespace HelloAndroid
{
    [Activity(Label = "LoginActivity")]
    public class LoginActivity : Activity
    {
        TextView textView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.LoginPage);
            // Create your application here

            textView = FindViewById<TextView>(Resource.Id.lblUsername);

            string serializedData = Intent.GetStringExtra("relatedStudent");
            //Student selectedPerson = JsonConvert.DeserializeObject<Student>(serializedData);
            Student selectedPerson = serializedData.JsonToData<Student>();

            textView.Text = selectedPerson.Username;

            Toast.MakeText(this, selectedPerson.Username, ToastLength.Short).Show();
        }
    }
}