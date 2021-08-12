using SQLiteTutorial.Model;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SQLiteTutorial
{
    public partial class App : Application
    {

        //Singleton Pattern.
        private static MyDatabase _myDatabase;
        public static MyDatabase myDatabase
        {
            get
            {
                if (_myDatabase==null)
                {
                    string dbNameOnFolder = "people.db3";
                    var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), dbNameOnFolder);
                    _myDatabase = new MyDatabase(path);
                }
                return _myDatabase;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
