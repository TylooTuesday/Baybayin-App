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
    public partial class LessonsPage : ContentPage
    {
        public LessonsPage()
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
                    L2.SetOnAppTheme<FileImageSource>(Image.SourceProperty, "btnAralin2L.png", "btnAralin2D.png");
                }
                if (records[1].RecordDate != "")
                {
                    b3 = true;
                    L3.SetOnAppTheme<FileImageSource>(Image.SourceProperty, "btnAralin3L.png", "btnAralin3D.png");
                }
                if (records[12].RecordDate != "")
                {
                    b4 = true;
                    L4.SetOnAppTheme<FileImageSource>(Image.SourceProperty, "btnAralin4L.png", "btnAralin4D.png");
                }
                if (records[3].RecordDate != "")
                {
                    b5 = true;
                    L5.SetOnAppTheme<FileImageSource>(Image.SourceProperty, "btnAralin5L.png", "btnAralin5D.png");
                }
                if (records[4].RecordDate != "")
                {
                    b6 = true;
                    L6.SetOnAppTheme<FileImageSource>(Image.SourceProperty, "btnAralin6L.png", "btnAralin6D.png");
                }
                if (records[13].RecordDate != "")
                {
                    b7 = true;
                    L7.SetOnAppTheme<FileImageSource>(Image.SourceProperty, "btnAralin7L.png", "btnAralin7D.png");
                }
                if (records[6].RecordDate != "")
                {
                    b8 = true;
                    L8.SetOnAppTheme<FileImageSource>(Image.SourceProperty, "btnAralin8L.png", "btnAralin8D.png");
                }
                if (records[7].RecordDate != "")
                {
                    b9 = true;
                    L9.SetOnAppTheme<FileImageSource>(Image.SourceProperty, "btnAralin9L.png", "btnAralin9D.png");
                }
                if (records[8].RecordDate != "")
                {
                    b10 = true;
                    L10.SetOnAppTheme<FileImageSource>(Image.SourceProperty, "btnAralin10L.png", "btnAralin10D.png");
                }
                if (records[14].RecordDate != "")
                {
                    b11 = true;
                    L11.SetOnAppTheme<FileImageSource>(Image.SourceProperty, "btnAralin11L.png", "btnAralin11D.png");
                }
                if (records[10].RecordDate != "")
                {
                    b12 = true;
                    L12.SetOnAppTheme<FileImageSource>(Image.SourceProperty, "btnAralin12L.png", "btnAralin12D.png");
                }
            }
        }

        private async void Lesson1Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(Lesson1Page)}");
        }
        private async void Lesson2Clicked(object sender, EventArgs e)
        {
            if (b2 == true)
            {
                await Shell.Current.GoToAsync($"{nameof(Lesson2Page)}");
            }
            else
            {
                await DisplayAlert("Paunawa", "Tapusin muna ang Gawain 1", "OK");
            }
        }
        private async void Lesson3Clicked(object sender, EventArgs e)
        {
            if (b3 == true)
            {
                await Shell.Current.GoToAsync($"{nameof(Lesson3Page)}");
            }
            else
            {
                await DisplayAlert("Paunawa", "Tapusin muna ang Gawain 2", "OK");
            }
        }
        private async void Lesson4Clicked(object sender, EventArgs e)
        {
            if (b4 == true)
            {
                await Shell.Current.GoToAsync($"{nameof(Lesson4Page)}");
            }
            else
            {
                await DisplayAlert("Paunawa", "Tapusin muna ang Pagsusulit 1", "OK");
            }
        }
        private async void Lesson5Clicked(object sender, EventArgs e)
        {
            if (b5 == true)
            {
                await Shell.Current.GoToAsync($"{nameof(Lesson5Page)}");
            }
            else
            {
                await DisplayAlert("Paunawa", "Tapusin muna ang Gawain 4", "OK");
            }
        }
        private async void Lesson6Clicked(object sender, EventArgs e)
        {
            if (b6 == true)
            {
                await Shell.Current.GoToAsync($"{nameof(Lesson6Page)}");
            }
            else
            {
                await DisplayAlert("Paunawa", "Tapusin muna ang Gawain 5", "OK");
            }
        }
        private async void Lesson7Clicked(object sender, EventArgs e)
        {
            if (b7 == true)
            {
                await Shell.Current.GoToAsync($"{nameof(Lesson7Page)}");
            }
            else
            {
                await DisplayAlert("Paunawa", "Tapusin muna ang Pagsusulit 2", "OK");
            }
        }
        private async void Lesson8Clicked(object sender, EventArgs e)
        {
            if (b8 == true)
            {
                await Shell.Current.GoToAsync($"{nameof(Lesson8Page)}");
            }
            else
            {
                await DisplayAlert("Paunawa", "Tapusin muna ang Gawain 7", "OK");
            }
        }
        private async void Lesson9Clicked(object sender, EventArgs e)
        {
            if (b9 == true)
            {
                await Shell.Current.GoToAsync($"{nameof(Lesson9Page)}");
            }
            else
            {
                await DisplayAlert("Paunawa", "Tapusin muna ang Gawain 8", "OK");
            }
        }
        private async void Lesson10Clicked(object sender, EventArgs e)
        {
            if (b10 == true)
            {
                await Shell.Current.GoToAsync($"{nameof(Lesson10Page)}");
            }
            else
            {
                await DisplayAlert("Paunawa", "Tapusin muna ang Gawain 9", "OK");
            }
        }
        private async void Lesson11Clicked(object sender, EventArgs e)
        {
            if (b11 == true)
            {
                await Shell.Current.GoToAsync($"{nameof(Lesson11Page)}");
            }
            else
            {
                await DisplayAlert("Paunawa", "Tapusin muna ang Pagsusulit 3", "OK");
            }
        }
        private async void Lesson12Clicked(object sender, EventArgs e)
        {
            if (b12 == true)
            {
                await Shell.Current.GoToAsync($"{nameof(Lesson12Page)}");
            }
            else
            {
                await DisplayAlert("Paunawa", "Tapusin muna ang Gawain 11", "OK");
            }
        }
    }
}