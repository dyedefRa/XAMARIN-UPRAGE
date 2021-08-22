using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBinding.Pages.Sample1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sample1Page : ContentPage
    {
        public Sample1Page()
        {
            InitializeComponent();
            BindingContext = new MyBindingObject();
        }
    }
}