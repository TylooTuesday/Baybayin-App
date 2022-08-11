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
    public partial class Lesson2Page : ContentPage
    {
        public Lesson2Page()
        {
            InitializeComponent();
        }
        private void ClickedBI(object sender, EventArgs e)
        {
            CloseAllMedia();
            vidBI.HeightRequest = 200;
            vidBI.Source = "ms-appx:///BI.mp4";
        }
        private void ClickedNI(object sender, EventArgs e)
        {
            CloseAllMedia();
            vidNI.HeightRequest = 200;
            vidNI.Source = "ms-appx:///NI.mp4";
        }
        private void ClickedHU(object sender, EventArgs e)
        {
            CloseAllMedia();
            vidHU.HeightRequest = 200;
            vidHU.Source = "ms-appx:///HU.mp4";
        }
        private void ClickedYU(object sender, EventArgs e)
        {
            CloseAllMedia();
            vidYU.HeightRequest = 200;
            vidYU.Source = "ms-appx:///YU.mp4";
        }
        private void MediaEnded(object sender, EventArgs e)
        {
            CloseAllMedia();
        }
        private void CloseAllMedia()
        {
            vidBI.HeightRequest = 0;
            vidBI.Source = null;
            vidNI.HeightRequest = 0;
            vidNI.Source = null;
            vidHU.HeightRequest = 0;
            vidHU.Source = null;
            vidYU.HeightRequest = 0;
            vidYU.Source = null;
        }
        private async void ActivityClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"../{nameof(Activity2Page)}");
        }
    }
}