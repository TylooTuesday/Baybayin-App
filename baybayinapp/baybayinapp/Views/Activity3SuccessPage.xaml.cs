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
    public partial class Activity3SuccessPage : ContentPage
    {
        public Activity3SuccessPage()
        {
            InitializeComponent();
        }
        private async void Quiz1Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"../../{nameof(Quiz1Page)}");
        }
        private async void BackClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}