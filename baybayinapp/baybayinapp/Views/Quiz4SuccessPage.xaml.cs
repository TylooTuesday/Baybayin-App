using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace baybayinapp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Quiz4SuccessPage : ContentPage
    {
        public Quiz4SuccessPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            string text = File.ReadAllText(App.tempFile);

            lblScore.Text = text;
        }
        private async void RepeatClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"../../../../");
        }
        private async void BackClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}