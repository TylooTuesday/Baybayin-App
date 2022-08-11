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
    public partial class Beginner : ContentPage
    {
        public Beginner()
        {
            InitializeComponent();
        }
        private async void Lesson1Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(BLesson1)}");
        }
        private async void Lesson2Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(BLesson2)}");
        }
        private async void Lesson3Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(BLesson3)}");
        }
    }
}