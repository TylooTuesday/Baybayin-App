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
    public partial class Lesson3Page : ContentPage
    {
        public Lesson3Page()
        {
            InitializeComponent();
        }
        private void ClickedHS(object sender, EventArgs e)
        {
            CloseAllMedia();
            vidHS.HeightRequest = 200;
            vidHS.Source = "ms-appx:///HS.mp4";
        }
        private void ClickedHV(object sender, EventArgs e)
        {
            CloseAllMedia();
            vidHV.HeightRequest = 200;
            vidHV.Source = "ms-appx:///HV.mp4";
        }
        private void ClickedHP(object sender, EventArgs e)
        {
            CloseAllMedia();
            vidHP.HeightRequest = 200;
            vidHP.Source = "ms-appx:///HP.mp4";
        }
        private void ClickedKS(object sender, EventArgs e)
        {
            CloseAllMedia();
            vidKS.HeightRequest = 200;
            vidKS.Source = "ms-appx:///KS.mp4";
        }
        private void ClickedKV(object sender, EventArgs e)
        {
            CloseAllMedia();
            vidKV.HeightRequest = 200;
            vidKV.Source = "ms-appx:///KV.mp4";
        }
        private void ClickedKP(object sender, EventArgs e)
        {
            CloseAllMedia();
            vidKP.HeightRequest = 200;
            vidKP.Source = "ms-appx:///KP.mp4";
        }
        private void ClickedLS(object sender, EventArgs e)
        {
            CloseAllMedia();
            vidLS.HeightRequest = 200;
            vidLS.Source = "ms-appx:///LS.mp4";
        }
        private void ClickedLV(object sender, EventArgs e)
        {
            CloseAllMedia();
            vidLV.HeightRequest = 200;
            vidLV.Source = "ms-appx:///LV.mp4";
        }
        private void ClickedLP(object sender, EventArgs e)
        {
            CloseAllMedia();
            vidLP.HeightRequest = 200;
            vidLP.Source = "ms-appx:///LP.mp4";
        }
        private void MediaEnded(object sender, EventArgs e)
        {
            CloseAllMedia();
        }
        private void CloseAllMedia()
        {
            vidHS.HeightRequest = 0;
            vidHS.Source = null;
            vidHV.HeightRequest = 0;
            vidHV.Source = null;
            vidHP.HeightRequest = 0;
            vidHP.Source = null;
            vidKS.HeightRequest = 0;
            vidKS.Source = null;
            vidKV.HeightRequest = 0;
            vidKV.Source = null;
            vidKP.HeightRequest = 0;
            vidKP.Source = null;
            vidLS.HeightRequest = 0;
            vidLS.Source = null;
            vidLV.HeightRequest = 0;
            vidLV.Source = null;
            vidLP.HeightRequest = 0;
            vidLP.Source = null;
        }
        private async void ActivityClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"../{nameof(Activity3Page)}");
        }
    }
}