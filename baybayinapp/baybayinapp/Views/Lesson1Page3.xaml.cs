using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace baybayinapp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lesson1Page3 : ContentPage
    {
        public Lesson1Page3()
        {
            InitializeComponent();
        }
        private void ClickedNA(object sender, EventArgs e)
        {
            CloseAllMedia();
            vidNA.HeightRequest = 200;
            vidNA.Source = "ms-appx:///NA.mp4";
        }
        private void ClickedNGA(object sender, EventArgs e)
        {
            CloseAllMedia();
            vidNGA.HeightRequest = 200;
            vidNGA.Source = "ms-appx:///NGA.mp4";
        }
        private void ClickedPA(object sender, EventArgs e)
        {
            CloseAllMedia();
            vidPA.HeightRequest = 200;
            vidPA.Source = "ms-appx:///PA.mp4";
        }
        private void ClickedSA(object sender, EventArgs e)
        {
            CloseAllMedia();
            vidSA.HeightRequest = 200;
            vidSA.Source = "ms-appx:///SA.mp4";
        }
        private void ClickedTA(object sender, EventArgs e)
        {
            CloseAllMedia();
            vidTA.HeightRequest = 200;
            vidTA.Source = "ms-appx:///TA.mp4";
        }
        private void ClickedWA(object sender, EventArgs e)
        {
            CloseAllMedia();
            vidWA.HeightRequest = 200;
            vidWA.Source = "ms-appx:///WA.mp4";
        }
        private void ClickedYA(object sender, EventArgs e)
        {
            CloseAllMedia();
            vidYA.HeightRequest = 200;
            vidYA.Source = "ms-appx:///YA.mp4";
        }
        private void MediaEnded(object sender, EventArgs e)
        {
            CloseAllMedia();
        }
        private void CloseAllMedia()
        {
            vidNA.HeightRequest = 0;
            vidNA.Source = null;
            vidNGA.HeightRequest = 0;
            vidNGA.Source = null;
            vidPA.HeightRequest = 0;
            vidPA.Source = null;
            vidSA.HeightRequest = 0;
            vidSA.Source = null;
            vidTA.HeightRequest = 0;
            vidTA.Source = null;
            vidWA.HeightRequest = 0;
            vidWA.Source = null;
            vidYA.HeightRequest = 0;
            vidYA.Source = null;
        }
        private async void ActivityClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"../../../{nameof(Activity1Page)}");
        }
    }
}