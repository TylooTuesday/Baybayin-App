using baybayinapp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace baybayinapp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestPage : ContentPage
    {
        public TestPage()
        {
            InitializeComponent();

            BindingContext = this;
        }

        int count = 0;
        string countDisplay = "Click Me";
        public string CountDisplay
        {
            get => countDisplay;
            set
            {
                if (value == countDisplay)
                    return;
                countDisplay = value;
                OnPropertyChanged();
            }
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetRecordsAsync();
        }

        private async void IncrementClicked(object sender, EventArgs e)
        {
            count++;
            CountDisplay = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));

            Record record1 = new Record() { Id = 1, RecordName = "Activity 1", RecordType = "Activity", RecordScore = 0, RecordDate = "" };
            Record record2 = new Record() { Id = 2, RecordName = "Activity 2", RecordType = "Activity", RecordScore = 0, RecordDate = "" };
            Record record3 = new Record() { Id = 3, RecordName = "Activity 3", RecordType = "Activity", RecordScore = 0, RecordDate = "" };
            Record record4 = new Record() { Id = 4, RecordName = "Activity 4", RecordType = "Activity", RecordScore = 0, RecordDate = "" };
            Record record5 = new Record() { Id = 5, RecordName = "Activity 5", RecordType = "Activity", RecordScore = 0, RecordDate = "" };
            Record record6 = new Record() { Id = 6, RecordName = "Activity 6", RecordType = "Activity", RecordScore = 0, RecordDate = "" };
            Record record7 = new Record() { Id = 7, RecordName = "Activity 7", RecordType = "Activity", RecordScore = 0, RecordDate = "" };
            Record record8 = new Record() { Id = 8, RecordName = "Activity 8", RecordType = "Activity", RecordScore = 0, RecordDate = "" };
            Record record9 = new Record() { Id = 9, RecordName = "Activity 9", RecordType = "Activity", RecordScore = 0, RecordDate = "" };
            Record record10 = new Record() { Id = 10, RecordName = "Activity 10", RecordType = "Activity", RecordScore = 0, RecordDate = "" };
            Record record11 = new Record() { Id = 11, RecordName = "Activity 11", RecordType = "Activity", RecordScore = 0, RecordDate = "" };
            Record record12 = new Record() { Id = 12, RecordName = "Activity 12", RecordType = "Activity", RecordScore = 0, RecordDate = "" };
            Record record13 = new Record() { Id = 13, RecordName = "Quiz 1", RecordType = "Quiz", RecordScore = 0, RecordDate = "" };
            Record record14 = new Record() { Id = 14, RecordName = "Quiz 2", RecordType = "Quiz", RecordScore = 0, RecordDate = "" };
            Record record15 = new Record() { Id = 15, RecordName = "Quiz 3", RecordType = "Quiz", RecordScore = 0, RecordDate = "" };
            Record record16 = new Record() { Id = 16, RecordName = "Quiz 4", RecordType = "Quiz", RecordScore = 0, RecordDate = "" };
            using (SQLiteConnection c = new SQLiteConnection(App.dbFile))
            {
                c.CreateTable<Record>();
                c.Update(record1);
                c.Update(record2);
                c.Update(record3);
                c.Update(record4);
                c.Update(record5);
                c.Update(record6);
                c.Update(record7);
                c.Update(record8);
                c.Update(record9);
                c.Update(record10);
                c.Update(record11);
                c.Update(record12);
                c.Update(record13);
                c.Update(record14);
                c.Update(record15);
                c.Update(record16);
            }
            collectionView.ItemsSource = await App.Database.GetRecordsAsync();
        }

        private void BtnClicked(object sender, EventArgs e)
        {
            File.Copy(Path.Combine("/storage/emulated/0/Android/data/com.companyname.baybayinapp/files/", "db.db3"), Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "db.db3"));
        }

        private async void A1Clicked(object sender, EventArgs e)
        {
            Record record = new Record() { Id = 1, RecordName = "Activity 1", RecordType = "Activity", RecordScore = 17, RecordDate = DateTime.Today.ToLongDateString() };
            using (SQLiteConnection c = new SQLiteConnection(App.dbFile))
            {
                c.CreateTable<Record>();
                c.Update(record);
            }
            collectionView.ItemsSource = await App.Database.GetRecordsAsync();
        }
        private async void A2Clicked(object sender, EventArgs e)
        {
            Record record = new Record() { Id = 2, RecordName = "Activity 2", RecordType = "Activity", RecordScore = 5, RecordDate = DateTime.Today.ToLongDateString() };
            using (SQLiteConnection c = new SQLiteConnection(App.dbFile))
            {
                c.CreateTable<Record>();
                c.Update(record);
            }
            collectionView.ItemsSource = await App.Database.GetRecordsAsync();
        }
        private async void A3Clicked(object sender, EventArgs e)
        {
            Record record = new Record() { Id = 3, RecordName = "Activity 3", RecordType = "Activity", RecordScore = 5, RecordDate = DateTime.Today.ToLongDateString() };
            using (SQLiteConnection c = new SQLiteConnection(App.dbFile))
            {
                c.CreateTable<Record>();
                c.Update(record);
            }
            collectionView.ItemsSource = await App.Database.GetRecordsAsync();
        }
        private async void A4Clicked(object sender, EventArgs e)
        {
            Record record = new Record() { Id = 4, RecordName = "Activity 4", RecordType = "Activity", RecordScore = 5, RecordDate = DateTime.Today.ToLongDateString() };
            using (SQLiteConnection c = new SQLiteConnection(App.dbFile))
            {
                c.CreateTable<Record>();
                c.Update(record);
            }
            collectionView.ItemsSource = await App.Database.GetRecordsAsync();
        }
        private async void A5Clicked(object sender, EventArgs e)
        {
            Record record = new Record() { Id = 5, RecordName = "Activity 5", RecordType = "Activity", RecordScore = 5, RecordDate = DateTime.Today.ToLongDateString() };
            using (SQLiteConnection c = new SQLiteConnection(App.dbFile))
            {
                c.CreateTable<Record>();
                c.Update(record);
            }
            collectionView.ItemsSource = await App.Database.GetRecordsAsync();
        }
        private async void A6Clicked(object sender, EventArgs e)
        {
            Record record = new Record() { Id = 6, RecordName = "Activity 6", RecordType = "Activity", RecordScore = 5, RecordDate = DateTime.Today.ToLongDateString() };
            using (SQLiteConnection c = new SQLiteConnection(App.dbFile))
            {
                c.CreateTable<Record>();
                c.Update(record);
            }
            collectionView.ItemsSource = await App.Database.GetRecordsAsync();
        }
        private async void A7Clicked(object sender, EventArgs e)
        {
            Record record = new Record() { Id = 7, RecordName = "Activity 7", RecordType = "Activity", RecordScore = 5, RecordDate = DateTime.Today.ToLongDateString() };
            using (SQLiteConnection c = new SQLiteConnection(App.dbFile))
            {
                c.CreateTable<Record>();
                c.Update(record);
            }
            collectionView.ItemsSource = await App.Database.GetRecordsAsync();
        }
        private async void A8Clicked(object sender, EventArgs e)
        {
            Record record = new Record() { Id = 8, RecordName = "Activity 8", RecordType = "Activity", RecordScore = 5, RecordDate = DateTime.Today.ToLongDateString() };
            using (SQLiteConnection c = new SQLiteConnection(App.dbFile))
            {
                c.CreateTable<Record>();
                c.Update(record);
            }
            collectionView.ItemsSource = await App.Database.GetRecordsAsync();
        }
        private async void A9Clicked(object sender, EventArgs e)
        {
            Record record = new Record() { Id = 9, RecordName = "Activity 9", RecordType = "Activity", RecordScore = 5, RecordDate = DateTime.Today.ToLongDateString() };
            using (SQLiteConnection c = new SQLiteConnection(App.dbFile))
            {
                c.CreateTable<Record>();
                c.Update(record);
            }
            collectionView.ItemsSource = await App.Database.GetRecordsAsync();
        }
        private async void A10Clicked(object sender, EventArgs e)
        {
            Record record = new Record() { Id = 10, RecordName = "Activity 10", RecordType = "Activity", RecordScore = 5, RecordDate = DateTime.Today.ToLongDateString() };
            using (SQLiteConnection c = new SQLiteConnection(App.dbFile))
            {
                c.CreateTable<Record>();
                c.Update(record);
            }
            collectionView.ItemsSource = await App.Database.GetRecordsAsync();
        }
        private async void A11Clicked(object sender, EventArgs e)
        {
            Record record = new Record() { Id = 11, RecordName = "Activity 11", RecordType = "Activity", RecordScore = 5, RecordDate = DateTime.Today.ToLongDateString() };
            using (SQLiteConnection c = new SQLiteConnection(App.dbFile))
            {
                c.CreateTable<Record>();
                c.Update(record);
            }
            collectionView.ItemsSource = await App.Database.GetRecordsAsync();
        }
        private async void A12Clicked(object sender, EventArgs e)
        {
            Record record = new Record() { Id = 12, RecordName = "Activity 12", RecordType = "Activity", RecordScore = 5, RecordDate = DateTime.Today.ToLongDateString() };
            using (SQLiteConnection c = new SQLiteConnection(App.dbFile))
            {
                c.CreateTable<Record>();
                c.Update(record);
            }
            collectionView.ItemsSource = await App.Database.GetRecordsAsync();
        }
        private async void Q1Clicked(object sender, EventArgs e)
        {
            Record record = new Record() { Id = 13, RecordName = "Quiz 1", RecordType = "Quiz", RecordScore = 16, RecordDate = DateTime.Today.ToLongDateString() };
            using (SQLiteConnection c = new SQLiteConnection(App.dbFile))
            {
                c.CreateTable<Record>();
                c.Update(record);
            }
            collectionView.ItemsSource = await App.Database.GetRecordsAsync();
        }
        private async void Q2Clicked(object sender, EventArgs e)
        {
            Record record = new Record() { Id = 14, RecordName = "Quiz 2", RecordType = "Quiz", RecordScore = 15, RecordDate = DateTime.Today.ToLongDateString() };
            using (SQLiteConnection c = new SQLiteConnection(App.dbFile))
            {
                c.CreateTable<Record>();
                c.Update(record);
            }
            collectionView.ItemsSource = await App.Database.GetRecordsAsync();
        }
        private async void Q3Clicked(object sender, EventArgs e)
        {
            Record record = new Record() { Id = 15, RecordName = "Quiz 3", RecordType = "Quiz", RecordScore = 15, RecordDate = DateTime.Today.ToLongDateString() };
            using (SQLiteConnection c = new SQLiteConnection(App.dbFile))
            {
                c.CreateTable<Record>();
                c.Update(record);
            }
            collectionView.ItemsSource = await App.Database.GetRecordsAsync();
        }
        private async void Q4Clicked(object sender, EventArgs e)
        {
            Record record = new Record() { Id = 16, RecordName = "Quiz 4", RecordType = "Quiz", RecordScore = 15, RecordDate = DateTime.Today.ToLongDateString() };
            using (SQLiteConnection c = new SQLiteConnection(App.dbFile))
            {
                c.CreateTable<Record>();
                c.Update(record);
            }
            collectionView.ItemsSource = await App.Database.GetRecordsAsync();
        }
    }
}