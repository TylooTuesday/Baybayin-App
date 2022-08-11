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
    public partial class Lesson4Page : ContentPage
    {
        public Lesson4Page()
        {
            InitializeComponent();
        }
        private async void ActivityClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"../{nameof(Activity4Page)}");
        }
    }
}