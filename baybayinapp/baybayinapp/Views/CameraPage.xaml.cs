using baybayinapp.Models;
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction;
using Plugin.Connectivity;
using Plugin.Media;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace baybayinapp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CameraPage : ContentPage
    {
        public CameraPage()
        {
            InitializeComponent();
            CheckConnection();
        }

        private async void CheckConnection()
        {
            if (!CrossConnectivity.Current.IsConnected)
                await DisplayAlert("Paunawa", "Walang konksyon sa Internet", "OK");
            else
                return;
        }

        private async void CaptureImage(object sender, EventArgs e)
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                await DisplayAlert("Paunawa", "Walang konksyon sa Internet", "OK");
                return;
            }

            txtPanuto.IsVisible = false;
            txtPanutoTitle.IsVisible = false;

            var imageResult = await MediaPicker.CapturePhotoAsync();
            var stream = await imageResult.OpenReadAsync();
            var streamepic = await imageResult.OpenReadAsync();
            imgView.Source = ImageSource.FromStream(() => streamepic);

            txtResult.Text = "Binabasa...";

            MemoryStream memory = new MemoryStream();
            stream.CopyTo(memory);

            byte[] buffer = ImageResizer.ResizeImage(memory.ToArray(), 800, 800);
            Stream stream2 = new MemoryStream(buffer);

            var predictionClient = new CustomVisionPredictionClient
            {
                ApiKey = TracingCR.CustomVisionPredictionApiKey,
                Endpoint = TracingCR.PredictionUrl
            };

            var result = await predictionClient.ClassifyImageAsync(TracingCR.OCRProjectId, TracingCR.OCRIterationName, stream2);
            var bestResult = result.Predictions.OrderByDescending(p => p.Probability).FirstOrDefault();
            
            if (bestResult == null)
                return;

            txtResult.Text = bestResult.TagName.ToString();
        }
    }
}