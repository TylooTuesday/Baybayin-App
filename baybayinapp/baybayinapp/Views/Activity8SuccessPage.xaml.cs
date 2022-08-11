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
    public partial class Activity8SuccessPage : ContentPage
    {
        public Activity8SuccessPage()
        {
            InitializeComponent();
        }
        private async void Lesson9Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"../../{nameof(Lesson9Page)}");
        }
        private async void BackClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}