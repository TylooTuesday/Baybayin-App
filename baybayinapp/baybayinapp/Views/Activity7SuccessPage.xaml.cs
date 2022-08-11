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
    public partial class Activity7SuccessPage : ContentPage
    {
        public Activity7SuccessPage()
        {
            InitializeComponent();
        }
        private async void Lesson8Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"../../{nameof(Lesson8Page)}");
        }
        private async void BackClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}