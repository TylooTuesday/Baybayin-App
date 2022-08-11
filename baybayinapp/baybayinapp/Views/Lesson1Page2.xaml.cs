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
    public partial class Lesson1Page2 : ContentPage
    {
        public Lesson1Page2()
        {
            InitializeComponent();
        }
        private void ClickedBA(object sender, EventArgs e)
        {
            CloseAllMedia();
            vidBA.HeightRequest = 200;
            vidBA.Source = "ms-appx:///BA.mp4";
        }
        private void ClickedKA(object sender, EventArgs e)
        {
            CloseAllMedia();
            vidKA.HeightRequest = 200;
            vidKA.Source = "ms-appx:///KA.mp4";
        }
        private void ClickedDARA(object sender, EventArgs e)
        {
            CloseAllMedia();
            vidDARA.HeightRequest = 200;
            vidDARA.Source = "ms-appx:///DARA.mp4";
        }
        private void ClickedGA(object sender, EventArgs e)
        {
            CloseAllMedia();
            vidGA.HeightRequest = 200;
            vidGA.Source = "ms-appx:///GA.mp4";
        }
        private void ClickedHA(object sender, EventArgs e)
        {
            CloseAllMedia();
            vidHA.HeightRequest = 200;
            vidHA.Source = "ms-appx:///HA.mp4";
        }
        private void ClickedLA(object sender, EventArgs e)
        {
            CloseAllMedia();
            vidLA.HeightRequest = 200;
            vidLA.Source = "ms-appx:///LA.mp4";
        }
        private void ClickedMA(object sender, EventArgs e)
        {
            CloseAllMedia();
            vidMA.HeightRequest = 200;
            vidMA.Source = "ms-appx:///MA.mp4";
        }

        private void MediaEnded(object sender, EventArgs e)
        {
            CloseAllMedia();
        }
        private void CloseAllMedia()
        {
            vidBA.HeightRequest = 0;
            vidBA.Source = null;
            vidKA.HeightRequest = 0;
            vidKA.Source = null;
            vidDARA.HeightRequest = 0;
            vidDARA.Source = null;
            vidGA.HeightRequest = 0;
            vidGA.Source = null;
            vidHA.HeightRequest = 0;
            vidHA.Source = null;
            vidLA.HeightRequest = 0;
            vidLA.Source = null;
            vidMA.HeightRequest = 0;
            vidMA.Source = null;
        }
        private async void ProceedClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(Lesson1Page3)}");
        }
    }
}