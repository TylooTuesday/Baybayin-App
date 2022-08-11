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
    public partial class Activity1Page : ContentPage
    {
        public Activity1Page()
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

            if (bestResult.TagName.ToString() == "A")
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

            if (bestResult.TagName.ToString() == "I / E")
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

            if (bestResult.TagName.ToString() == "O / U")
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

            if (bestResult.TagName.ToString() == "Ba")
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

            if (bestResult.TagName.ToString() == "Ka")
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
        private async void q6Submit(object sender, EventArgs er)
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                await DisplayAlert("Paunawa", "Walang konksyon sa Internet", "OK");
                return;
            }

            Stream Image = await q6.GetImageStreamAsync(SignatureImageFormat.Jpeg);

            if (Image == null)
                return;

            q6Output.Text = "Binabasa ang iyong sagot...";
            q6Verdict.Text = "";

            var predictionClient = new CustomVisionPredictionClient
            {
                ApiKey = TracingCR.CustomVisionPredictionApiKey,
                Endpoint = TracingCR.PredictionUrl
            };

            var result = await predictionClient.ClassifyImageAsync(TracingCR.TracingProjectId, TracingCR.TracingIterationName, Image);
            var bestResult = result.Predictions.OrderByDescending(p => p.Probability).FirstOrDefault();

            if (bestResult == null)
                return;

            q6Output.Text = bestResult.TagName.ToString();

            if (bestResult.TagName.ToString() == "Da / Ra")
            {
                q6Verdict.Text = "TAMA";
                q6Verdict.TextColor = Color.Green;
            }
            else
            {
                q6Verdict.Text = "MALI";
                q6Verdict.TextColor = Color.Red;
            }
        }
        private void q6Clear(object sender, EventArgs e)
        {
            q6.Clear();
            q6Output.Text = "";
            q6Verdict.Text = "";
        }
        private async void q7Submit(object sender, EventArgs er)
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                await DisplayAlert("Paunawa", "Walang konksyon sa Internet", "OK");
                return;
            }

            Stream Image = await q7.GetImageStreamAsync(SignatureImageFormat.Jpeg);

            if (Image == null)
                return;

            q7Output.Text = "Binabasa ang iyong sagot...";
            q7Verdict.Text = "";

            var predictionClient = new CustomVisionPredictionClient
            {
                ApiKey = TracingCR.CustomVisionPredictionApiKey,
                Endpoint = TracingCR.PredictionUrl
            };

            var result = await predictionClient.ClassifyImageAsync(TracingCR.TracingProjectId, TracingCR.TracingIterationName, Image);
            var bestResult = result.Predictions.OrderByDescending(p => p.Probability).FirstOrDefault();

            if (bestResult == null)
                return;

            q7Output.Text = bestResult.TagName.ToString();

            if (bestResult.TagName.ToString() == "Ga")
            {
                q7Verdict.Text = "TAMA";
                q7Verdict.TextColor = Color.Green;
            }
            else
            {
                q7Verdict.Text = "MALI";
                q7Verdict.TextColor = Color.Red;
            }
        }
        private void q7Clear(object sender, EventArgs e)
        {
            q7.Clear();
            q7Output.Text = "";
            q7Verdict.Text = "";
        }
        private async void q8Submit(object sender, EventArgs er)
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                await DisplayAlert("Paunawa", "Walang konksyon sa Internet", "OK");
                return;
            }

            Stream Image = await q8.GetImageStreamAsync(SignatureImageFormat.Jpeg);

            if (Image == null)
                return;

            q8Output.Text = "Binabasa ang iyong sagot...";
            q8Verdict.Text = "";

            var predictionClient = new CustomVisionPredictionClient
            {
                ApiKey = TracingCR.CustomVisionPredictionApiKey,
                Endpoint = TracingCR.PredictionUrl
            };

            var result = await predictionClient.ClassifyImageAsync(TracingCR.TracingProjectId, TracingCR.TracingIterationName, Image);
            var bestResult = result.Predictions.OrderByDescending(p => p.Probability).FirstOrDefault();

            if (bestResult == null)
                return;

            q8Output.Text = bestResult.TagName.ToString();

            if (bestResult.TagName.ToString() == "Ha")
            {
                q8Verdict.Text = "TAMA";
                q8Verdict.TextColor = Color.Green;
            }
            else
            {
                q8Verdict.Text = "MALI";
                q8Verdict.TextColor = Color.Red;
            }
        }
        private void q8Clear(object sender, EventArgs e)
        {
            q8.Clear();
            q8Output.Text = "";
            q8Verdict.Text = "";
        }
        private async void q9Submit(object sender, EventArgs er)
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                await DisplayAlert("Paunawa", "Walang konksyon sa Internet", "OK");
                return;
            }

            Stream Image = await q9.GetImageStreamAsync(SignatureImageFormat.Jpeg);

            if (Image == null)
                return;

            q9Output.Text = "Binabasa ang iyong sagot...";
            q9Verdict.Text = "";

            var predictionClient = new CustomVisionPredictionClient
            {
                ApiKey = TracingCR.CustomVisionPredictionApiKey,
                Endpoint = TracingCR.PredictionUrl
            };

            var result = await predictionClient.ClassifyImageAsync(TracingCR.TracingProjectId, TracingCR.TracingIterationName, Image);
            var bestResult = result.Predictions.OrderByDescending(p => p.Probability).FirstOrDefault();

            if (bestResult == null)
                return;

            q9Output.Text = bestResult.TagName.ToString();

            if (bestResult.TagName.ToString() == "La")
            {
                q9Verdict.Text = "TAMA";
                q9Verdict.TextColor = Color.Green;
            }
            else
            {
                q9Verdict.Text = "MALI";
                q9Verdict.TextColor = Color.Red;
            }
        }
        private void q9Clear(object sender, EventArgs e)
        {
            q9.Clear();
            q9Output.Text = "";
            q9Verdict.Text = "";
        }
        private async void q10Submit(object sender, EventArgs er)
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                await DisplayAlert("Paunawa", "Walang konksyon sa Internet", "OK");
                return;
            }

            Stream Image = await q10.GetImageStreamAsync(SignatureImageFormat.Jpeg);

            if (Image == null)
                return;

            q10Output.Text = "Binabasa ang iyong sagot...";
            q10Verdict.Text = "";

            var predictionClient = new CustomVisionPredictionClient
            {
                ApiKey = TracingCR.CustomVisionPredictionApiKey,
                Endpoint = TracingCR.PredictionUrl
            };

            var result = await predictionClient.ClassifyImageAsync(TracingCR.TracingProjectId, TracingCR.TracingIterationName, Image);
            var bestResult = result.Predictions.OrderByDescending(p => p.Probability).FirstOrDefault();

            if (bestResult == null)
                return;

            q10Output.Text = bestResult.TagName.ToString();

            if (bestResult.TagName.ToString() == "Ma")
            {
                q10Verdict.Text = "TAMA";
                q10Verdict.TextColor = Color.Green;
            }
            else
            {
                q10Verdict.Text = "MALI";
                q10Verdict.TextColor = Color.Red;
            }
        }
        private void q10Clear(object sender, EventArgs e)
        {
            q10.Clear();
            q10Output.Text = "";
            q10Verdict.Text = "";
        }
        private async void q11Submit(object sender, EventArgs er)
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                await DisplayAlert("Paunawa", "Walang konksyon sa Internet", "OK");
                return;
            }

            Stream Image = await q11.GetImageStreamAsync(SignatureImageFormat.Jpeg);

            if (Image == null)
                return;

            q11Output.Text = "Binabasa ang iyong sagot...";
            q11Verdict.Text = "";

            var predictionClient = new CustomVisionPredictionClient
            {
                ApiKey = TracingCR.CustomVisionPredictionApiKey,
                Endpoint = TracingCR.PredictionUrl
            };

            var result = await predictionClient.ClassifyImageAsync(TracingCR.TracingProjectId, TracingCR.TracingIterationName, Image);
            var bestResult = result.Predictions.OrderByDescending(p => p.Probability).FirstOrDefault();

            if (bestResult == null)
                return;

            q11Output.Text = bestResult.TagName.ToString();

            if (bestResult.TagName.ToString() == "Na")
            {
                q11Verdict.Text = "TAMA";
                q11Verdict.TextColor = Color.Green;
            }
            else
            {
                q11Verdict.Text = "MALI";
                q11Verdict.TextColor = Color.Red;
            }
        }
        private void q11Clear(object sender, EventArgs e)
        {
            q11.Clear();
            q11Output.Text = "";
            q11Verdict.Text = "";
        }
        private async void q12Submit(object sender, EventArgs er)
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                await DisplayAlert("Paunawa", "Walang konksyon sa Internet", "OK");
                return;
            }

            Stream Image = await q12.GetImageStreamAsync(SignatureImageFormat.Jpeg);

            if (Image == null)
                return;

            q12Output.Text = "Binabasa ang iyong sagot...";
            q12Verdict.Text = "";

            var predictionClient = new CustomVisionPredictionClient
            {
                ApiKey = TracingCR.CustomVisionPredictionApiKey,
                Endpoint = TracingCR.PredictionUrl
            };

            var result = await predictionClient.ClassifyImageAsync(TracingCR.TracingProjectId, TracingCR.TracingIterationName, Image);
            var bestResult = result.Predictions.OrderByDescending(p => p.Probability).FirstOrDefault();

            if (bestResult == null)
                return;

            q12Output.Text = bestResult.TagName.ToString();

            if (bestResult.TagName.ToString() == "Nga")
            {
                q12Verdict.Text = "TAMA";
                q12Verdict.TextColor = Color.Green;
            }
            else
            {
                q12Verdict.Text = "MALI";
                q12Verdict.TextColor = Color.Red;
            }
        }
        private void q12Clear(object sender, EventArgs e)
        {
            q12.Clear();
            q12Output.Text = "";
            q12Verdict.Text = "";
        }
        private async void q13Submit(object sender, EventArgs er)
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                await DisplayAlert("Paunawa", "Walang konksyon sa Internet", "OK");
                return;
            }

            Stream Image = await q13.GetImageStreamAsync(SignatureImageFormat.Jpeg);

            if (Image == null)
                return;

            q13Output.Text = "Binabasa ang iyong sagot...";
            q13Verdict.Text = "";

            var predictionClient = new CustomVisionPredictionClient
            {
                ApiKey = TracingCR.CustomVisionPredictionApiKey,
                Endpoint = TracingCR.PredictionUrl
            };

            var result = await predictionClient.ClassifyImageAsync(TracingCR.TracingProjectId, TracingCR.TracingIterationName, Image);
            var bestResult = result.Predictions.OrderByDescending(p => p.Probability).FirstOrDefault();

            if (bestResult == null)
                return;

            q13Output.Text = bestResult.TagName.ToString();

            if (bestResult.TagName.ToString() == "Pa")
            {
                q13Verdict.Text = "TAMA";
                q13Verdict.TextColor = Color.Green;
            }
            else
            {
                q13Verdict.Text = "MALI";
                q13Verdict.TextColor = Color.Red;
            }
        }
        private void q13Clear(object sender, EventArgs e)
        {
            q13.Clear();
            q13Output.Text = "";
            q13Verdict.Text = "";
        }
        private async void q14Submit(object sender, EventArgs er)
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                await DisplayAlert("Paunawa", "Walang konksyon sa Internet", "OK");
                return;
            }

            Stream Image = await q14.GetImageStreamAsync(SignatureImageFormat.Jpeg);

            if (Image == null)
                return;

            q14Output.Text = "Binabasa ang iyong sagot...";
            q14Verdict.Text = "";

            var predictionClient = new CustomVisionPredictionClient
            {
                ApiKey = TracingCR.CustomVisionPredictionApiKey,
                Endpoint = TracingCR.PredictionUrl
            };

            var result = await predictionClient.ClassifyImageAsync(TracingCR.TracingProjectId, TracingCR.TracingIterationName, Image);
            var bestResult = result.Predictions.OrderByDescending(p => p.Probability).FirstOrDefault();

            if (bestResult == null)
                return;

            q14Output.Text = bestResult.TagName.ToString();

            if (bestResult.TagName.ToString() == "Sa")
            {
                q14Verdict.Text = "TAMA";
                q14Verdict.TextColor = Color.Green;
            }
            else
            {
                q14Verdict.Text = "MALI";
                q14Verdict.TextColor = Color.Red;
            }
        }
        private void q14Clear(object sender, EventArgs e)
        {
            q14.Clear();
            q14Output.Text = "";
            q14Verdict.Text = "";
        }
        private async void q15Submit(object sender, EventArgs er)
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                await DisplayAlert("Paunawa", "Walang konksyon sa Internet", "OK");
                return;
            }

            Stream Image = await q15.GetImageStreamAsync(SignatureImageFormat.Jpeg);

            if (Image == null)
                return;

            q15Output.Text = "Binabasa ang iyong sagot...";
            q15Verdict.Text = "";

            var predictionClient = new CustomVisionPredictionClient
            {
                ApiKey = TracingCR.CustomVisionPredictionApiKey,
                Endpoint = TracingCR.PredictionUrl
            };

            var result = await predictionClient.ClassifyImageAsync(TracingCR.TracingProjectId, TracingCR.TracingIterationName, Image);
            var bestResult = result.Predictions.OrderByDescending(p => p.Probability).FirstOrDefault();

            if (bestResult == null)
                return;

            q15Output.Text = bestResult.TagName.ToString();

            if (bestResult.TagName.ToString() == "Ta")
            {
                q15Verdict.Text = "TAMA";
                q15Verdict.TextColor = Color.Green;
            }
            else
            {
                q15Verdict.Text = "MALI";
                q15Verdict.TextColor = Color.Red;
            }
        }
        private void q15Clear(object sender, EventArgs e)
        {
            q15.Clear();
            q15Output.Text = "";
            q15Verdict.Text = "";
        }
        private async void q16Submit(object sender, EventArgs er)
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                await DisplayAlert("Paunawa", "Walang konksyon sa Internet", "OK");
                return;
            }

            Stream Image = await q16.GetImageStreamAsync(SignatureImageFormat.Jpeg);

            if (Image == null)
                return;

            q16Output.Text = "Binabasa ang iyong sagot...";
            q16Verdict.Text = "";

            var predictionClient = new CustomVisionPredictionClient
            {
                ApiKey = TracingCR.CustomVisionPredictionApiKey,
                Endpoint = TracingCR.PredictionUrl
            };

            var result = await predictionClient.ClassifyImageAsync(TracingCR.TracingProjectId, TracingCR.TracingIterationName, Image);
            var bestResult = result.Predictions.OrderByDescending(p => p.Probability).FirstOrDefault();

            if (bestResult == null)
                return;

            q16Output.Text = bestResult.TagName.ToString();

            if (bestResult.TagName.ToString() == "Wa")
            {
                q16Verdict.Text = "TAMA";
                q16Verdict.TextColor = Color.Green;
            }
            else
            {
                q16Verdict.Text = "MALI";
                q16Verdict.TextColor = Color.Red;
            }
        }
        private void q16Clear(object sender, EventArgs e)
        {
            q16.Clear();
            q16Output.Text = "";
            q16Verdict.Text = "";
        }
        private async void q17Submit(object sender, EventArgs er)
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                await DisplayAlert("Paunawa", "Walang konksyon sa Internet", "OK");
                return;
            }

            Stream Image = await q17.GetImageStreamAsync(SignatureImageFormat.Jpeg);

            if (Image == null)
                return;

            q17Output.Text = "Binabasa ang iyong sagot...";
            q17Verdict.Text = "";

            var predictionClient = new CustomVisionPredictionClient
            {
                ApiKey = TracingCR.CustomVisionPredictionApiKey,
                Endpoint = TracingCR.PredictionUrl
            };

            var result = await predictionClient.ClassifyImageAsync(TracingCR.TracingProjectId, TracingCR.TracingIterationName, Image);
            var bestResult = result.Predictions.OrderByDescending(p => p.Probability).FirstOrDefault();

            if (bestResult == null)
                return;

            q17Output.Text = bestResult.TagName.ToString();

            if (bestResult.TagName.ToString() == "Ya")
            {
                q17Verdict.Text = "TAMA";
                q17Verdict.TextColor = Color.Green;
            }
            else
            {
                q17Verdict.Text = "MALI";
                q17Verdict.TextColor = Color.Red;
            }
        }
        private void q17Clear(object sender, EventArgs e)
        {
            q17.Clear();
            q17Output.Text = "";
            q17Verdict.Text = "";
        }
        private async void ProceedClicked(object sender, EventArgs e)
        {
            var failedPage = new ActivityFailedPage();
            var successPage = new Activity1SuccessPage();
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
            if (q6Verdict.Text == "TAMA")
            {
                score++;
            }
            if (q7Verdict.Text == "TAMA")
            {
                score++;
            }
            if (q8Verdict.Text == "TAMA")
            {
                score++;
            }
            if (q9Verdict.Text == "TAMA")
            {
                score++;
            }
            if (q10Verdict.Text == "TAMA")
            {
                score++;
            }
            if (q11Verdict.Text == "TAMA")
            {
                score++;
            }
            if (q12Verdict.Text == "TAMA")
            {
                score++;
            }
            if (q13Verdict.Text == "TAMA")
            {
                score++;
            }
            if (q14Verdict.Text == "TAMA")
            {
                score++;
            }
            if (q15Verdict.Text == "TAMA")
            {
                score++;
            }
            if (q16Verdict.Text == "TAMA")
            {
                score++;
            }
            if (q17Verdict.Text == "TAMA")
            {
                score++;
            }

            if (score >= 17)
            {
                Record record = new Record()
                {
                    Id = 1,
                    RecordName = "Activity 1",
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
                File.WriteAllText(App.tempFile, score.ToString() + "/17");
                await Navigation.PushModalAsync(failedPage);
            }
        }
    }
}