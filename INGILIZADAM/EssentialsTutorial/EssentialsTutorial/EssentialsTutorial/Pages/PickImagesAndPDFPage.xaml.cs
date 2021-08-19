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
    public partial class PickImagesAndPDFPage : ContentPage
    {
        public PickImagesAndPDFPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var result = await FilePicker.PickAsync(
                new PickOptions()
                {
                    FileTypes = FilePickerFileType.Images,
                    PickerTitle = "Pick an Image"
                });

            if (result != null)
            {
                var stream = await result.OpenReadAsync();
                imgResult.Source = ImageSource.FromStream(() => stream);
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var result = await FilePicker.PickMultipleAsync(
               new PickOptions()
               {
                   FileTypes = FilePickerFileType.Images,
                   PickerTitle = "Pick Images"
               });

            if (result != null)
            {
                var imageList = new List<ImageSource>();
                foreach (var img in result)
                {
                    var stream = await img.OpenReadAsync();
                    imageList.Add(ImageSource.FromStream(() => stream));
                }
                collectImages.ItemsSource = imageList;
            }
        }
    }
}