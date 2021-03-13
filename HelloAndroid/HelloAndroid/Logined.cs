using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using HelloAndroid.Extension;
using HelloAndroid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloAndroid
{
    [Activity(Label = "Logined")]
    public class Logined : Activity
    {
        TextView textView;
        Button btnNavigateInsert;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Logined);
            //// Create your application here

            textView = FindViewById<TextView>(Resource.Id.tx);
            //btnNavigateInsert = FindViewById<Button>(
            //    Resource.Id.btnNavigateInsert);

            string serializedData = Intent.GetStringExtra("relatedStudent");
            //Student selectedPerson = JsonConvert.DeserializeObject<Student>(serializedData);
            Student selectedPerson = serializedData.JsonToData<Student>();

            textView.Text = selectedPerson.Username;
            btnNavigateInsert.Click += BtnNavigateInsert_Click;

            Toast.MakeText(this, selectedPerson.Username, ToastLength.Short).Show();
        }

        private void BtnNavigateInsert_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(InsertActivity));

        }
    }
}