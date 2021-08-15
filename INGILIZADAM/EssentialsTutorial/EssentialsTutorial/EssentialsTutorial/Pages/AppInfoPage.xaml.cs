using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace EssentialsTutorial.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppInfoPage : ContentPage
    {
        public AppInfoPage()
        {
            InitializeComponent();
            txtAppName.Text = AppInfo.Name;
            txtPackageName.Text = AppInfo.PackageName;
            txtVersion.Text = AppInfo.VersionString;
            txtBuild.Text = AppInfo.BuildString;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            AppInfo.ShowSettingsUI();
        }
    }
}