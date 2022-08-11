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
    public partial class ActivitiesPage : ContentPage
    {
        public ActivitiesPage()
        {
            InitializeComponent();
        }

        bool b2;
        bool b3;
        bool b4;
        bool b5;
        bool b6;
        bool b7;
        bool b8;
        bool b9;
        bool b10;
        bool b11;
        bool b12;

        protected override void OnAppearing()
        {
            base.OnAppearing();
            b2 = false; b3 = false; b4 = false; b5 = false; b6 = false; b7 = false; b8 = false; b9 = false; b10 = false; b11 = false; b12 = false;
            using (SQLiteConnection c = new SQLiteConnection(App.dbFile))
            {
                c.CreateTable<Record>();
                var records = c.Table<Record>().ToList();

                if (records[0].RecordDate != "")
                {
                    b2 = true;
                    A2.SetOnAppTheme<FileImageSource>(Image.SourceProperty, "btnGawain2L.png", "btnGawain2D.png");
                }
                if (records[1].RecordDate != "")
                {
                    b3 = true;
                    A3.SetOnAppTheme<FileImageSource>(Image.SourceProperty, "btnGawain3L.png", "btnGawain3D.png");
                }
                if (records[12].RecordDate != "")
                {
                    b4 = true;
                    A4.SetOnAppTheme<FileImageSource>(Image.SourceProperty, "btnGawain4L.png", "btnGawain4D.png");
                }
                if (records[3].RecordDate != "")
                {
                    b5 = true;
                    A5.SetOnAppTheme<FileImageSource>(Image.SourceProperty, "btnGawain5L.png", "btnGawain5D.png");
                }
                if (records[4].RecordDate != "")
                {
                    b6 = true;
                    A6.SetOnAppTheme<FileImageSource>(Image.SourceProperty, "btnGawain6L.png", "btnGawain6D.png");
                }
                if (records[13].RecordDate != "")
                {
                    b7 = true;
                    A7.SetOnAppTheme<FileImageSource>(Image.SourceProperty, "btnGawain7L.png", "btnGawain7D.png");
                }
                if (records[6].RecordDate != "")
                {
                    b8 = true;
                    A8.SetOnAppTheme<FileImageSource>(Image.SourceProperty, "btnGawain8L.png", "btnGawain8D.png");
                }
                if (records[7].RecordDate != "")
                {
                    b9 = true;
                    A9.SetOnAppTheme<FileImageSource>(Image.SourceProperty, "btnGawain9L.png", "btnGawain9D.png");
                }
                if (records[8].RecordDate != "")
                {
                    b10 = true;
                    A10.SetOnAppTheme<FileImageSource>(Image.SourceProperty, "btnGawain10L.png", "btnGawain10D.png");
                }
                if (records[14].RecordDate != "")
                {
                    b11 = true;
                    A11.SetOnAppTheme<FileImageSource>(Image.SourceProperty, "btnGawain11L.png", "btnGawain11D.png");
                }
                if (records[10].RecordDate != "")
                {
                    b12 = true;
                    A12.SetOnAppTheme<FileImageSource>(Image.SourceProperty, "btnGawain12L.png", "btnGawain12D.png");
                }
            }
        }

        private async void Activity1Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(Activity1Page)}");
        }
        private async void Activity2Clicked(object sender, EventArgs e)
        {
            if (b2 == true)
            {
                await Shell.Current.GoToAsync($"{nameof(Activity2Page)}");
            }
            else
            {
                await DisplayAlert("Paunawa", "Tapusin muna ang Gawain 1", "OK");
            }
        }
        private async void Activity3Clicked(object sender, EventArgs e)
        {
            if (b3 == true)
            {
                await Shell.Current.GoToAsync($"{nameof(Activity3Page)}");
            }
            else
            {
                await DisplayAlert("Paunawa", "Tapusin muna ang Gawain 2", "OK");
            }
        }
        private async void Activity4Clicked(object sender, EventArgs e)
        {
            if (b4 == true)
            {
                await Shell.Current.GoToAsync($"{nameof(Activity4Page)}");
            }
            else
            {
                await DisplayAlert("Paunawa", "Tapusin muna ang Pagsusulit 1", "OK");
            }
        }
        private async void Activity5Clicked(object sender, EventArgs e)
        {
            if (b5 == true)
            {
                await Shell.Current.GoToAsync($"{nameof(Activity5Page)}");
            }
            else
            {
                await DisplayAlert("Paunawa", "Tapusin muna ang Gawain 4", "OK");
            }
        }
        private async void Activity6Clicked(object sender, EventArgs e)
        {
            if (b6 == true)
            {
                await Shell.Current.GoToAsync($"{nameof(Activity6Page)}");
            }
            else
            {
                await DisplayAlert("Paunawa", "Tapusin muna ang Gawain 5", "OK");
            }
        }
        private async void Activity7Clicked(object sender, EventArgs e)
        {
            if (b7 == true)
            {
                await Shell.Current.GoToAsync($"{nameof(Activity7Page)}");
            }
            else
            {
                await DisplayAlert("Paunawa", "Tapusin muna ang Pagsusulit 2", "OK");
            }
        }
        private async void Activity8Clicked(object sender, EventArgs e)
        {
            if (b8 == true)
            {
                await Shell.Current.GoToAsync($"{nameof(Activity8Page)}");
            }
            else
            {
                await DisplayAlert("Paunawa", "Tapusin muna ang Gawain 7", "OK");
            }
        }
        private async void Activity9Clicked(object sender, EventArgs e)
        {
            if (b9 == true)
            {
                await Shell.Current.GoToAsync($"{nameof(Activity9Page)}");
            }
            else
            {
                await DisplayAlert("Paunawa", "Tapusin muna ang Gawain 8", "OK");
            }
        }
        private async void Activity10Clicked(object sender, EventArgs e)
        {
            if (b10 == true)
            {
                await Shell.Current.GoToAsync($"{nameof(Activity10Page)}");
            }
            else
            {
                await DisplayAlert("Paunawa", "Tapusin muna ang Gawain 9", "OK");
            }
        }
        private async void Activity11Clicked(object sender, EventArgs e)
        {
            if (b11 == true)
            {
                await Shell.Current.GoToAsync($"{nameof(Activity11Page)}");
            }
            else
            {
                await DisplayAlert("Paunawa", "Tapusin muna ang Pagsusulit 3", "OK");
            }
        }
        private async void Activity12Clicked(object sender, EventArgs e)
        {
            if (b12 == true)
            {
                await Shell.Current.GoToAsync($"{nameof(Activity12Page)}");
            }
            else
            {
                await DisplayAlert("Paunawa", "Tapusin muna ang Gawain 11", "OK");
            }
        }
    }
}