using baybayinapp.Models;
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction;
using Plugin.Connectivity;
using SignaturePad.Forms;
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
    public partial class Activity3Page : ContentPage
    {
        public Activity3Page()
        {
            InitializeComponent();
        }
        private async void q1Submit(object sender, EventArgs er)
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                await DisplayAlert("Paunawa", "Walang konksyon sa Internet", "OK");
                return;
            }

            Stream Image = await q1.GetImageStreamAsync(SignatureImageFormat.Jpeg);

            if (Image == null)
                return;

            q1Output.Text = "Binabasa ang iyong sagot...";
            q1Verdict.Text = "";

            var predictionClient = new CustomVisionPredictionClient
            {
                ApiKey = TracingCR.CustomVisionPredictionApiKey,
                Endpoint = TracingCR.PredictionUrl
            };

            var result = await predictionClient.ClassifyImageAsync(TracingCR.TracingProjectId, TracingCR.TracingIterationName, Image);
            var bestResult = result.Predictions.OrderByDescending(p => p.Probability).FirstOrDefault();

            if (bestResult == null)
                return;

            q1Output.Text = bestResult.TagName.ToString();

            if (bestResult.TagName.ToString() == "D / R Sinawali")
            {
                q1Verdict.Text = "TAMA";
                q1Verdict.TextColor = Color.Green;
            }
            else
            {
                q1Verdict.Text = "MALI";
                q1Verdict.TextColor = Color.Red;
            }
        }
        private void q1Clear(object sender, EventArgs e)
        {
            q1.Clear();
            q1Output.Text = "";
            q1Verdict.Text = "";
        }
        private async void q2Submit(object sender, EventArgs er)
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                await DisplayAlert("Paunawa", "Walang konksyon sa Internet", "OK");
                return;
            }

            Stream Image = await q2.GetImageStreamAsync(SignatureImageFormat.Jpeg);

            if (Image == null)
                return;

            q2Output.Text = "Binabasa ang iyong sagot...";
            q2Verdict.Text = "";

            var predictionClient = new CustomVisionPredictionClient
            {
                ApiKey = TracingCR.CustomVisionPredictionApiKey,
                Endpoint = TracingCR.PredictionUrl
            };

            var result = await predictionClient.ClassifyImageAsync(TracingCR.TracingProjectId, TracingCR.TracingIterationName, Image);
            var bestResult = result.Predictions.OrderByDescending(p => p.Probability).FirstOrDefault();

            if (bestResult == null)
                return;

            q2Output.Text = bestResult.TagName.ToString();

            if (bestResult.TagName.ToString() == "M Sabat")
            {
                q2Verdict.Text = "TAMA";
                q2Verdict.TextColor = Color.Green;
            }
            else
            {
                q2Verdict.Text = "MALI";
                q2Verdict.TextColor = Color.Red;
            }
        }
        private void q2Clear(object sender, EventArgs e)
        {
            q2.Clear();
            q2Output.Text = "";
            q2Verdict.Text = "";
        }
        private async void q3Submit(object sender, EventArgs er)
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                await DisplayAlert("Paunawa", "Walang konksyon sa Internet", "OK");
                return;
            }

            Stream Image = await q3.GetImageStreamAsync(SignatureImageFormat.Jpeg);

            if (Image == null)
                return;

            q3Output.Text = "Binabasa ang iyong sagot...";
            q3Verdict.Text = "";

            var predictionClient = new CustomVisionPredictionClient
            {
                ApiKey = TracingCR.CustomVisionPredictionApiKey,
                Endpoint = TracingCR.PredictionUrl
            };

            var result = await predictionClient.ClassifyImageAsync(TracingCR.TracingProjectId, TracingCR.TracingIterationName, Image);
            var bestResult = result.Predictions.OrderByDescending(p => p.Probability).FirstOrDefault();

            if (bestResult == null)
                return;

            q3Output.Text = bestResult.TagName.ToString();

            if (bestResult.TagName.ToString() == "Ng Pamudpod")
            {
                q3Verdict.Text = "TAMA";
                q3Verdict.TextColor = Color.Green;
            }
            else
            {
                q3Verdict.Text = "MALI";
                q3Verdict.TextColor = Color.Red;
            }
        }
        private void q3Clear(object sender, EventArgs e)
        {
            q3.Clear();
            q3Output.Text = "";
            q3Verdict.Text = "";
        }
        private async void q4Submit(object sender, EventArgs er)
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                await DisplayAlert("Paunawa", "Walang konksyon sa Internet", "OK");
                return;
            }

            Stream Image = await q4.GetImageStreamAsync(SignatureImageFormat.Jpeg);

            if (Image == null)
                return;

            q4Output.Text = "Binabasa ang iyong sagot...";
            q4Verdict.Text = "";

            var predictionClient = new CustomVisionPredictionClient
            {
                ApiKey = TracingCR.CustomVisionPredictionApiKey,
                Endpoint = TracingCR.PredictionUrl
            };

            var result = await predictionClient.ClassifyImageAsync(TracingCR.TracingProjectId, TracingCR.TracingIterationName, Image);
            var bestResult = result.Predictions.OrderByDescending(p => p.Probability).FirstOrDefault();

            if (bestResult == null)
                return;

            q4Output.Text = bestResult.TagName.ToString();

            if (bestResult.TagName.ToString() == "P Sinawali")
            {
                q4Verdict.Text = "TAMA";
                q4Verdict.TextColor = Color.Green;
            }
            else
            {
                q4Verdict.Text = "MALI";
                q4Verdict.TextColor = Color.Red;
            }
        }
        private void q4Clear(object sender, EventArgs e)
        {
            q4.Clear();
            q4Output.Text = "";
            q4Verdict.Text = "";
        }
        private async void q5Submit(object sender, EventArgs er)
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                await DisplayAlert("Paunawa", "Walang konksyon sa Internet", "OK");
                return;
            }

            Stream Image = await q5.GetImageStreamAsync(SignatureImageFormat.Jpeg);

            if (Image == null)
                return;

            q5Output.Text = "Binabasa ang iyong sagot...";
            q5Verdict.Text = "";

            var predictionClient = new CustomVisionPredictionClient
            {
                ApiKey = TracingCR.CustomVisionPredictionApiKey,
                Endpoint = TracingCR.PredictionUrl
            };

            var result = await predictionClient.ClassifyImageAsync(TracingCR.TracingProjectId, TracingCR.TracingIterationName, Image);
            var bestResult = result.Predictions.OrderByDescending(p => p.Probability).FirstOrDefault();

            if (bestResult == null)
                return;

            q5Output.Text = bestResult.TagName.ToString();

            if (bestResult.TagName.ToString() == "T Pamudpod")
            {
                q5Verdict.Text = "TAMA";
                q5Verdict.TextColor = Color.Green;
            }
            else
            {
                q5Verdict.Text = "MALI";
                q5Verdict.TextColor = Color.Red;
            }
        }
        private void q5Clear(object sender, EventArgs e)
        {
            q5.Clear();
            q5Output.Text = "";
            q5Verdict.Text = "";
        }
        private async void ProceedClicked(object sender, EventArgs e)
        {
            var failedPage = new ActivityFailedPage();
            var successPage = new Activity3SuccessPage();
            int score = 0;

            if (q1Verdict.Text == "TAMA")
            {
                score++;
            }
            if (q2Verdict.Text == "TAMA")
            {
                score++;
            }
            if (q3Verdict.Text == "TAMA")
            {
                score++;
            }
            if (q4Verdict.Text == "TAMA")
            {
                score++;
            }
            if (q5Verdict.Text == "TAMA")
            {
                score++;
            }

            if (score >= 5)
            {
                Record record = new Record()
                {
                    Id = 3,
                    RecordName = "Activity 3",
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
                File.WriteAllText(App.tempFile, score.ToString() + "/5");
                await Navigation.PushModalAsync(failedPage);
            }
        }
    }
}