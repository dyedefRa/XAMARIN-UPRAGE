using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Firebase;
using Firebase.Database;

namespace UberApp.Helper
{
    public class FirebaseClient
    {
       

        public static void InitializeDatabase()
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


            DatabaseReference dbref = database.GetReference("UserSupport");
            dbref.SetValue("Ticket1");

            Toast.MakeText(Application.Context, "Completed", ToastLength.Short).Show();
        }

        //public static FirebaseDatabase GetDatabase()
        //{
        //    var app = FirebaseApp.InitializeApp(Application.Context);
        //    FirebaseDatabase database;

        //    if (app == null)
        //    {
        //        var option = new FirebaseOptions.Builder()
        //           .SetApplicationId("uberapp-56725")
        //           .SetApiKey("AIzaSyAmZzmZD9EXFvqruksdNSHPYH6VV1e6uxw")
        //           .SetDatabaseUrl("https://uberapp-56725-default-rtdb.firebaseio.com/")
        //           .SetStorageBucket("uberapp-56725.appspot.com")
        //           .Build();
        //        app = FirebaseApp.InitializeApp(Application.Context, option);

        //    }
        //    database = FirebaseDatabase.GetInstance(app);

        //    DatabaseReference dbref = database.GetReference("UserSupport");
        //    dbref.SetValue("Ticket2");

        //    Toast.MakeText(Application.Context, "Completed", ToastLength.Short).Show();
        //    return database;
        //}
    }
}