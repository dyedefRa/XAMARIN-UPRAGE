using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using Plugin.AudioRecorder;

namespace EssentialsTutorial.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AudioPage : ContentPage
    {
        private readonly AudioRecorderService audioRecorderService = new AudioRecorderService();
        private readonly AudioPlayer audioPlayer = new AudioPlayer();

        public AudioPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var status = await Permissions.RequestAsync<Permissions.Microphone>();

            if (status != PermissionStatus.Granted)
            {
                return;
            }

            if (audioRecorderService.IsRecording)
            {
                await audioRecorderService.StopRecording();
                audioPlayer.Play(audioRecorderService.GetAudioFilePath());
                await DisplayAlert("AudioRecorder", audioRecorderService.GetAudioFilePath() + " kaydedildi", "Tamam");
            }
            else
                await audioRecorderService.StartRecording();
        }
    }
}