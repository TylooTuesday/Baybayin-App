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
    public partial class Quiz4Page : ContentPage
    {
        public Quiz4Page()
        {
            InitializeComponent();

            BindingContext = this;
        }

        // Next Page
        private async void ProceedClicked(object sender, EventArgs e)
        {
            int score = 0;
            if (q1.IsChecked)
            {
                score++;
            }
            if (q2.IsChecked)
            {
                score++;
            }
            if (q3.IsChecked)
            {
                score++;
            }
            if (q4.IsChecked)
            {
                score++;
            }
            if (q5.IsChecked)
            {
                score++;
            }
            if (q6.IsChecked)
            {
                score++;
            }
            if (q7.IsChecked)
            {
                score++;
            }
            if (q8.IsChecked)
            {
                score++;
            }
            if (q9.IsChecked)
            {
                score++;
            }
            if (q10.IsChecked)
            {
                score++;
            }
            File.WriteAllText(App.tempFile1, score.ToString());
            await Shell.Current.GoToAsync($"{nameof(Quiz4Page2)}");
        }
    }
}