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
    public partial class Quiz2SuccessPage : ContentPage
    {
        public Quiz2SuccessPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            string text = File.ReadAllText(App.tempFile);

            lblScore.Text = text;
        }
        private async void Lesson7Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"../../{nameof(Lesson7Page)}");
        }
        private async void BackClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}