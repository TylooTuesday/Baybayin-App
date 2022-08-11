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
    public partial class Activity11SuccessPage : ContentPage
    {
        public Activity11SuccessPage()
        {
            InitializeComponent();
        }
        private async void Lesson12Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"../../{nameof(Lesson12Page)}");
        }
        private async void BackClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}