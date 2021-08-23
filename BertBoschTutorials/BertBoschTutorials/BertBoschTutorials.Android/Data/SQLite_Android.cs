using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using BertBoschTutorials.Data;
using BertBoschTutorials.Droid.Data;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xamarin.Forms;

[assembly:Dependency(typeof(SQLite_Android))]
namespace BertBoschTutorials.Droid.Data
{
    public class SQLite_Android : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqllitefilename = "TestDb.db3";
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath, sqllitefilename);


            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }
    }
}