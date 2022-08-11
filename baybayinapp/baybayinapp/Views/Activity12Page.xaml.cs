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
    public partial class Activity12Page : ContentPage
    {
        public Activity12Page()
        {
            InitializeComponent();
        }
        private async void ProceedClicked(object sender, EventArgs e)
        {
            var failedPage = new ActivityFailedPage();
            var successPage = new Activity12SuccessPage();

            int score = 0;
            if (q1.IsChecked == true)
            {
                score++;
            }
            if (q2.IsChecked == true)
            {
                score++;
            }
            if (q3.IsChecked == true)
            {
                score++;
            }
            if (q4.IsChecked == true)
            {
                score++;
            }
            if (q5.IsChecked == true)
            {
                score++;
            }
            if (score >= 5)
            {
                Record record = new Record()
                {
                    Id = 12,
                    RecordName = "Activity 12",
                    RecordType = "Activity",
                    RecordScore = score,
                    RecordDate = DateTime.Today.ToLongDateString()
                };
                using (SQLiteConnection c = new SQLiteConnection(App.dbFile))
                {
                    c.Update(record);
                }
                await Navigation.PushModalAsync(successPage);
            }
            else
            {
                File.WriteAllText(App.tempFile, score.ToString() + "/10");
                await Navigation.PushModalAsync(failedPage);
            }
        }
    }
}