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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await App.Database.GetRecordsAsync();
        }

        private async void OCRClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(CameraPage)}");
        }
        private async void LearnClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(LearnPage)}");
        }
        private async void HistoryClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(History)}");
        }
        private async void AchievementsClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(Achievements)}");
            //await Shell.Current.GoToAsync($"{nameof(Achievements)}");
        }
    }
}