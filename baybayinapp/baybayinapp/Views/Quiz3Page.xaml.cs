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
    public partial class Quiz3Page : ContentPage
    {
        public Quiz3Page()
        {
            InitializeComponent();
        }
        private async void ProceedClicked(object sender, EventArgs e)
        {
            var failedPage = new Quiz4FailPage();
            var successPage = new Quiz3SuccessPage();

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
            if (q6.IsChecked == true)
            {
                score++;
            }
            if (q7.IsChecked == true)
            {
                score++;
            }
            if (q8.IsChecked == true)
            {
                score++;
            }
            if (q9.IsChecked == true)
            {
                score++;
            }
            if (q10.IsChecked == true)
            {
                score++;
            }
            if (q11.IsChecked == true)
            {
                score++;
            }
            if (q12.IsChecked == true)
            {
                score++;
            }
            if (q13.IsChecked == true)
            {
                score++;
            }
            if (q14.IsChecked == true)
            {
                score++;
            }
            if (q15.IsChecked == true)
            {
                score++;
            }
            File.WriteAllText(App.tempFile, score.ToString() + "/15");
            if (score >= 12)
            {
                Record record = new Record()
                {
                    Id = 15,
                    RecordName = "Quiz 3",
                    RecordType = "Quiz",
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
                await Navigation.PushModalAsync(failedPage);
            }
        }
    }
}