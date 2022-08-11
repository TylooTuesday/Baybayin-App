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
    public partial class Lesson1Page : ContentPage
    {
        public Lesson1Page()
        {
            InitializeComponent();
        }
        private void ClickedA(object sender, EventArgs e)
        {
            CloseAllMedia();
            vidA.HeightRequest = 200;
            vidA.Source = "ms-appx:///A.mp4";
        }
        private void ClickedEI(object sender, EventArgs e)
        {
            CloseAllMedia();
            vidEI.HeightRequest = 200;
            vidEI.Source = "ms-appx:///EI.mp4";
        }
        private void ClickedOU(object sender, EventArgs e)
        {
            CloseAllMedia();
            vidOU.HeightRequest = 200;
            vidOU.Source = "ms-appx:///OU.mp4";
        }
        private void MediaEnded(object sender, EventArgs e)
        {
            CloseAllMedia();
        }
        private void CloseAllMedia()
        {
            vidA.HeightRequest = 0;
            vidA.Source = null;
            vidEI.HeightRequest = 0;
            vidEI.Source = null;
            vidOU.HeightRequest = 0;
            vidOU.Source = null;
        }
        private async void ProceedClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(Lesson1Page2)}");
        }
    }
}