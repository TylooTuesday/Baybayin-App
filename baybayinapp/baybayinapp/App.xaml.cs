using baybayinapp.Models;
using baybayinapp.Services;
using baybayinapp.Views;
using SQLite;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace baybayinapp
{
    public partial class App : Application
    {
        private static Database database;
        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "db.db3"));


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
                        Record test = c.FindWithQuery<Record>("SELECT * FROM Record WHERE Id = ?", 1);
                        if (test == null)
                        {
                            c.Insert(record1);
                            c.Insert(record2);
                            c.Insert(record3);
                            c.Insert(record4);
                            c.Insert(record5);
                            c.Insert(record6);
                            c.Insert(record7);
                            c.Insert(record8);
                            c.Insert(record9);
                            c.Insert(record10);
                            c.Insert(record11);
                            c.Insert(record12);
                            c.Insert(record13);
                            c.Insert(record14);
                            c.Insert(record15);
                            c.Insert(record16);
                        }
                    }
                }

                return database;
            }
        }
        public static string tempFile1 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "temp1.txt");
        public static string tempFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "temp.txt");
        public static string dbFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "db.db3");
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
