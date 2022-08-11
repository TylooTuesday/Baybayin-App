using baybayinapp.Models;
using Microcharts;
using SkiaSharp;
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
    public partial class Achievements : ContentPage
    {
 
        public Achievements()
        {
            InitializeComponent();
        }

        public void DisplayChart()
        {
            int activities;
            int quizzes;

            activities = 0;
            quizzes = 0;

            using (SQLiteConnection c = new SQLiteConnection(App.dbFile))
            {
                c.CreateTable<Record>();
                var records = c.Table<Record>().ToList();

                for (int i = 0; i < 16; i++)
                {
                    if (records[i].RecordDate != "" && i <= 11)
                    {
                        activities++;
                    }
                    if (records[i].RecordDate != "" && i > 11)
                    {
                        quizzes++;
                    }
                }
            }

            OPercent.Text = ((activities + quizzes) * 100 / 16).ToString() + "%";
            APercent.Text = (activities * 100 / 12).ToString() + "%";
            QPercent.Text = (quizzes * 100 / 4).ToString() + "%";

            OTotal.Text = "Mga naipasa: " + (activities + quizzes).ToString();
            ATotal.Text = "Mga naipasa: " + activities.ToString();
            QTotal.Text = "Mga naipasa: " + quizzes.ToString();

            var OverallEntries = new[]
            {
                new ChartEntry(activities + quizzes)
                {
                    Label = "",
                    Color = SKColor.Parse(GetTheme())
                },
                new ChartEntry(16 - (activities + quizzes))
                {
                    Label = "",
                    Color = SKColor.Parse("#8d8d8d")
                }
            };
            var ActivityEntries = new[]
            {
                new ChartEntry(activities)
                {
                    Label = "",
                    Color = SKColor.Parse(GetTheme())
                },
                new ChartEntry(12 - activities)
                {
                    Label = "",
                    Color = SKColor.Parse("#8d8d8d")
                }
            };
            var QuizEntries = new[]
            {
                new ChartEntry(quizzes)
                {
                    Label = "",
                    Color = SKColor.Parse(GetTheme())
                },
                new ChartEntry(4 - quizzes)
                {
                    Label = "",
                    Color = SKColor.Parse("#8d8d8d")
                }
            };

            OverallChart.Chart = new DonutChart { Entries = OverallEntries, LabelTextSize = 40, BackgroundColor = SKColors.Transparent };
            ActivitiesChart.Chart = new DonutChart { Entries = ActivityEntries, LabelTextSize = 40, BackgroundColor = SKColors.Transparent };
            QuizzesChart.Chart = new DonutChart { Entries = QuizEntries, LabelTextSize = 40, BackgroundColor = SKColors.Transparent };
        }

        private String GetTheme()
        {
            string theme = "#e9e363";
            OSAppTheme currentTheme = Application.Current.RequestedTheme;
            if (currentTheme == OSAppTheme.Dark)
            {
                theme = "#6b7128";
            }
            return theme;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            DisplayChart();
        }
        /*
        private ChartEntry[] ActivityEntries = new[]
        {
            new ChartEntry(10)
            {
                Label = "Progreso",
                ValueLabel = a.ToString(),
                Color = SkiaSharp.SKColor.Parse("#d8d467")
            },
            new ChartEntry(20)
            {
                Label = "Mga Kakulangan",
                ValueLabel = q.ToString(),
                Color = SkiaSharp.SKColor.Parse("#fff2c4")
            }
        };*/
        private async void Epic(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(TestPage)}");
        }
    }
}