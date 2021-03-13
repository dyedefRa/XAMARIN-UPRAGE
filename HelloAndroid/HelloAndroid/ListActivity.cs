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
    [Activity(Label = "ListActivity")]
    public class ListActivity : Activity
    {
        ListView listView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //SetContentView(Resource.Layout.ListPage);

            //listView = FindViewById<ListView>(Resource.Id.lstStudents);

            //ArrayAdapter<Student> adapter = new ArrayAdapter<Student>(this,Android.Resource.Layout.SimpleListItem1,Android.Resource.Id.Text1,MainActivity.students);

            //listView.Adapter = adapter;
            // Create your application here
        }
    }
}