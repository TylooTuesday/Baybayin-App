using baybayinapp.Models;
using SQLite;
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
    public partial class QuizzesPage : ContentPage
    {
        public QuizzesPage()
        {
            InitializeComponent();
        }
        bool b1;
        bool b2;
        bool b3;
        bool b4;

        protected override void OnAppearing()
        {
            base.OnAppearing();
            b1 = false;  b2 = false; b3 = false; b4 = false;
            using (SQLiteConnection c = new SQLiteConnection(App.dbFile))
            {
                c.CreateTable<Record>();
                var records = c.Table<Record>().ToList();

                if (records[2].RecordDate != "")
                {
                    b1 = true;
                    Q1.SetOnAppTheme<FileImageSource>(Image.SourceProperty, "btnPagsusulit1L.png", "btnPagsusulit1D.png");
                }
                if (records[5].RecordDate != "")
                {
                    b2 = true;
                    Q2.SetOnAppTheme<FileImageSource>(Image.SourceProperty, "btnPagsusulit2L.png", "btnPagsusulit2D.png");
                }
                if (records[9].RecordDate != "")
                {
                    b3 = true;
                    Q3.SetOnAppTheme<FileImageSource>(Image.SourceProperty, "btnPagsusulit3L.png", "btnPagsusulit3D.png");
                }
                if (records[11].RecordDate != "")
                {
                    b4 = true;
                    Q4.SetOnAppTheme<FileImageSource>(Image.SourceProperty, "btnPagsusulit4L.png", "btnPagsusulit4D.png");
                }
            }
        }
        private async void Quiz1Clicked(object sender, EventArgs e)
        {
            if (b1 == true)
            {
                await Shell.Current.GoToAsync($"{nameof(Quiz1Page)}");
            }
            else
            {
                await DisplayAlert("Paunawa", "Tapusin muna ang Gawain 3", "OK");
            }
        }
        private async void Quiz2Clicked(object sender, EventArgs e)
        {
            if (b2 == true)
            {
                await Shell.Current.GoToAsync($"{nameof(Quiz2Page)}");
            }
            else
            {
                await DisplayAlert("Paunawa", "Tapusin muna ang Gawain 6", "OK");
            }
        }
        private async void Quiz3Clicked(object sender, EventArgs e)
        {
            if (b3 == true)
            {
                await Shell.Current.GoToAsync($"{nameof(Quiz3Page)}");
            }
            else
            {
                await DisplayAlert("Paunawa", "Tapusin muna ang Gawain 10", "OK");
            }
        }
        private async void Quiz4Clicked(object sender, EventArgs e)
        {
            if (b4 == true)
            {
                await Shell.Current.GoToAsync($"{nameof(Quiz4Page)}");
            }
            else
            {
                await DisplayAlert("Paunawa", "Tapusin muna ang Gawain 12", "OK");
            }
        }
    }
}