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
    public partial class LearnPage : ContentPage
    {
        public LearnPage()
        {
            InitializeComponent();
        }
        private async void LessonsClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(LessonsPage)}");
        }
        private async void ActivitiesClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(ActivitiesPage)}");
        }
        private async void QuizzesClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(QuizzesPage)}");
        }
    }
}