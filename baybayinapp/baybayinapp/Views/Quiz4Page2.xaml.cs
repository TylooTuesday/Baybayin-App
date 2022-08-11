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
    public partial class Quiz4Page2 : ContentPage
    {
        public Quiz4Page2()
        {
            InitializeComponent();

            k1.HeightRequest = 0;
            k1.IsVisible = false;
            k2.HeightRequest = 0;
            k2.IsVisible = false;
            k3.HeightRequest = 0;
            k3.IsVisible = false;
            k4.HeightRequest = 0;
            k4.IsVisible = false;
            k5.HeightRequest = 0;
            k5.IsVisible = false;

            a8q11Active = new Command(q11Active);
            a8q12Active = new Command(q12Active);
            a8q13Active = new Command(q13Active);
            a8q14Active = new Command(q14Active);
            a8q15Active = new Command(q15Active);

            a8q11Type = new Command<string>(q11Append);
            a8q11Clear = new Command(q11Clear);
            a8q12Type = new Command<string>(q12Append);
            a8q12Clear = new Command(q12Clear);
            a8q13Type = new Command<string>(q13Append);
            a8q13Clear = new Command(q13Clear);
            a8q14Type = new Command<string>(q14Append);
            a8q14Clear = new Command(q14Clear);
            a8q15Type = new Command<string>(q15Append);
            a8q15Clear = new Command(q15Clear);

            BindingContext = this;
        }
        public Command a8q11Active { get; }
        public Command a8q12Active { get; }
        public Command a8q13Active { get; }
        public Command a8q14Active { get; }
        public Command a8q15Active { get; }

        private void q11Active()
        {
            k1.HeightRequest = 210;
            k1.IsVisible = true;
            k2.HeightRequest = 0;
            k2.IsVisible = false;
            k3.HeightRequest = 0;
            k3.IsVisible = false;
            k4.HeightRequest = 0;
            k4.IsVisible = false;
            k5.HeightRequest = 0;
            k5.IsVisible = false;
        }
        private void q12Active()
        {
            k1.HeightRequest = 0;
            k1.IsVisible = false;
            k2.HeightRequest = 210;
            k2.IsVisible = true;
            k3.HeightRequest = 0;
            k3.IsVisible = false;
            k4.HeightRequest = 0;
            k4.IsVisible = false;
            k5.HeightRequest = 0;
            k5.IsVisible = false;
        }
        private void q13Active()
        {
            k1.HeightRequest = 0;
            k1.IsVisible = false;
            k2.HeightRequest = 0;
            k2.IsVisible = false;
            k3.HeightRequest = 210;
            k3.IsVisible = true;
            k4.HeightRequest = 0;
            k4.IsVisible = false;
            k5.HeightRequest = 0;
            k5.IsVisible = false;
        }
        private void q14Active()
        {
            k1.HeightRequest = 0;
            k1.IsVisible = false;
            k2.HeightRequest = 0;
            k2.IsVisible = false;
            k3.HeightRequest = 0;
            k3.IsVisible = false;
            k4.HeightRequest = 210;
            k4.IsVisible = true;
            k5.HeightRequest = 0;
            k5.IsVisible = false;
        }
        private void q15Active()
        {
            k1.HeightRequest = 0;
            k1.IsVisible = false;
            k2.HeightRequest = 0;
            k2.IsVisible = false;
            k3.HeightRequest = 0;
            k3.IsVisible = false;
            k4.HeightRequest = 0;
            k4.IsVisible = false;
            k5.HeightRequest = 210;
            k5.IsVisible = true;
        }

        //Keyboard Functions
        public Command<string> a8q11Type { get; }
        public Command a8q11Clear { get; }
        public Command<string> a8q12Type { get; }
        public Command a8q12Clear { get; }
        public Command<string> a8q13Type { get; }
        public Command a8q13Clear { get; }
        public Command<string> a8q14Type { get; }
        public Command a8q14Clear { get; }
        public Command<string> a8q15Type { get; }
        public Command a8q15Clear { get; }

        private void q11Append(string ch)
        {
            q11Verdict.Text = "";
            if (q11.Text == "Magsulat dito..." && (ch != "ᜒ" || ch != "ᜓ" || ch != "᜔" || ch != " " || ch != "᜶"))
            {
                q11.Text = ch;
                q11.FontAttributes = FontAttributes.None;
                q11.SetAppThemeColor(Label.TextColorProperty, Color.FromHex("#505050"), Color.FromHex("#eeeeee"));
            }
            else
            {
                if (((q11.Text[q11.Text.Length - 1] == 'ᜀ' || q11.Text[q11.Text.Length - 1] == 'ᜁ' || q11.Text[q11.Text.Length - 1] == 'ᜂ' || q11.Text[q11.Text.Length - 1] == 'ᜒ' || q11.Text[q11.Text.Length - 1] == 'ᜓ' || q11.Text[q11.Text.Length - 1] == '᜔' || q11.Text[q11.Text.Length - 1] == '᜶' || q11.Text[q11.Text.Length - 1] == ' ') && (ch == "ᜒ" || ch == "ᜓ" || ch == "᜔")) || (q11.Text[q11.Text.Length - 1] == ' ' && (ch == " " || ch == "᜶")) || (q11.Text[q11.Text.Length - 1] == '᜶' && ch == "᜶"))
                {
                    q11.Text = q11.Text;
                }
                else
                {
                    q11.Text = q11.Text + ch;
                }
            }
        }
        private void q11Clear()
        {
            q11Verdict.Text = "";
            q11.Text = "Magsulat dito...";
            q11.FontAttributes = FontAttributes.Italic;
            q11.TextColor = Color.FromRgb(127, 127, 127);
        }
        private void q11Back(object sender, EventArgs e)
        {
            q11Verdict.Text = "";
            if (q11.Text != "Magsulat dito...")
            {
                q11.Text = q11.Text.Substring(0, q11.Text.Length - 1);

                if (q11.Text == "")
                {
                    q11.Text = "Magsulat dito...";
                    q11.FontAttributes = FontAttributes.Italic;
                    q11.TextColor = Color.FromRgb(127, 127, 127);
                }
            }
        }

        private void q12Append(string ch)
        {
            q12Verdict.Text = "";
            if (q12.Text == "Magsulat dito..." && (ch != "ᜒ" || ch != "ᜓ" || ch != "᜔" || ch != " " || ch != "᜶"))
            {
                q12.Text = ch;
                q12.FontAttributes = FontAttributes.None;
                q12.SetAppThemeColor(Label.TextColorProperty, Color.FromHex("#505050"), Color.FromHex("#eeeeee"));
            }
            else
            {
                if (((q12.Text[q12.Text.Length - 1] == 'ᜀ' || q12.Text[q12.Text.Length - 1] == 'ᜁ' || q12.Text[q12.Text.Length - 1] == 'ᜂ' || q12.Text[q12.Text.Length - 1] == 'ᜒ' || q12.Text[q12.Text.Length - 1] == 'ᜓ' || q12.Text[q12.Text.Length - 1] == '᜔' || q12.Text[q12.Text.Length - 1] == '᜶' || q12.Text[q12.Text.Length - 1] == ' ') && (ch == "ᜒ" || ch == "ᜓ" || ch == "᜔")) || (q12.Text[q12.Text.Length - 1] == ' ' && (ch == " " || ch == "᜶")) || (q12.Text[q12.Text.Length - 1] == '᜶' && ch == "᜶"))
                {
                    q12.Text = q12.Text;
                }
                else
                {
                    q12.Text = q12.Text + ch;
                }
            }
        }
        private void q12Clear()
        {
            q12Verdict.Text = "";
            q12.Text = "Magsulat dito...";
            q12.FontAttributes = FontAttributes.Italic;
            q12.TextColor = Color.FromRgb(127, 127, 127);
        }
        private void q12Back(object sender, EventArgs e)
        {
            q12Verdict.Text = "";
            if (q12.Text != "Magsulat dito...")
            {
                q12.Text = q12.Text.Substring(0, q12.Text.Length - 1);

                if (q12.Text == "")
                {
                    q12.Text = "Magsulat dito...";
                    q12.FontAttributes = FontAttributes.Italic;
                    q12.TextColor = Color.FromRgb(127, 127, 127);
                }
            }
        }

        private void q13Append(string ch)
        {
            q13Verdict.Text = "";
            if (q13.Text == "Magsulat dito..." && (ch != "ᜒ" || ch != "ᜓ" || ch != "᜔" || ch != " " || ch != "᜶"))
            {
                q13.Text = ch;
                q13.FontAttributes = FontAttributes.None;
                q13.SetAppThemeColor(Label.TextColorProperty, Color.FromHex("#505050"), Color.FromHex("#eeeeee"));
            }
            else
            {
                if (((q13.Text[q13.Text.Length - 1] == 'ᜀ' || q13.Text[q13.Text.Length - 1] == 'ᜁ' || q13.Text[q13.Text.Length - 1] == 'ᜂ' || q13.Text[q13.Text.Length - 1] == 'ᜒ' || q13.Text[q13.Text.Length - 1] == 'ᜓ' || q13.Text[q13.Text.Length - 1] == '᜔' || q13.Text[q13.Text.Length - 1] == '᜶' || q13.Text[q13.Text.Length - 1] == ' ') && (ch == "ᜒ" || ch == "ᜓ" || ch == "᜔")) || (q13.Text[q13.Text.Length - 1] == ' ' && (ch == " " || ch == "᜶")) || (q13.Text[q13.Text.Length - 1] == '᜶' && ch == "᜶"))
                {
                    q13.Text = q13.Text;
                }
                else
                {
                    q13.Text = q13.Text + ch;
                }
            }
        }
        private void q13Clear()
        {
            q13Verdict.Text = "";
            q13.Text = "Magsulat dito...";
            q13.FontAttributes = FontAttributes.Italic;
            q13.TextColor = Color.FromRgb(127, 127, 127);
        }
        private void q13Back(object sender, EventArgs e)
        {
            q13Verdict.Text = "";
            if (q13.Text != "Magsulat dito...")
            {
                q13.Text = q13.Text.Substring(0, q13.Text.Length - 1);

                if (q13.Text == "")
                {
                    q13.Text = "Magsulat dito...";
                    q13.FontAttributes = FontAttributes.Italic;
                    q13.TextColor = Color.FromRgb(127, 127, 127);
                }
            }
        }

        private void q14Append(string ch)
        {
            q14Verdict.Text = "";
            if (q14.Text == "Magsulat dito..." && (ch != "ᜒ" || ch != "ᜓ" || ch != "᜔" || ch != " " || ch != "᜶"))
            {
                q14.Text = ch;
                q14.FontAttributes = FontAttributes.None;
                q14.SetAppThemeColor(Label.TextColorProperty, Color.FromHex("#505050"), Color.FromHex("#eeeeee"));
            }
            else
            {
                if (((q14.Text[q14.Text.Length - 1] == 'ᜀ' || q14.Text[q14.Text.Length - 1] == 'ᜁ' || q14.Text[q14.Text.Length - 1] == 'ᜂ' || q14.Text[q14.Text.Length - 1] == 'ᜒ' || q14.Text[q14.Text.Length - 1] == 'ᜓ' || q14.Text[q14.Text.Length - 1] == '᜔' || q14.Text[q14.Text.Length - 1] == '᜶' || q14.Text[q14.Text.Length - 1] == ' ') && (ch == "ᜒ" || ch == "ᜓ" || ch == "᜔")) || (q14.Text[q14.Text.Length - 1] == ' ' && (ch == " " || ch == "᜶")) || (q14.Text[q14.Text.Length - 1] == '᜶' && ch == "᜶"))
                {
                    q14.Text = q14.Text;
                }
                else
                {
                    q14.Text = q14.Text + ch;
                }
            }
        }
        private void q14Clear()
        {
            q14Verdict.Text = "";
            q14.Text = "Magsulat dito...";
            q14.FontAttributes = FontAttributes.Italic;
            q14.TextColor = Color.FromRgb(127, 127, 127);
        }
        private void q14Back(object sender, EventArgs e)
        {
            q14Verdict.Text = "";
            if (q14.Text != "Magsulat dito...")
            {
                q14.Text = q14.Text.Substring(0, q14.Text.Length - 1);

                if (q14.Text == "")
                {
                    q14.Text = "Magsulat dito...";
                    q14.FontAttributes = FontAttributes.Italic;
                    q14.TextColor = Color.FromRgb(127, 127, 127);
                }
            }
        }

        private void q15Append(string ch)
        {
            q15Verdict.Text = "";
            if (q15.Text == "Magsulat dito..." && (ch != "ᜒ" || ch != "ᜓ" || ch != "᜔" || ch != " " || ch != "᜶"))
            {
                q15.Text = ch;
                q15.FontAttributes = FontAttributes.None;
                q15.SetAppThemeColor(Label.TextColorProperty, Color.FromHex("#505050"), Color.FromHex("#eeeeee"));
            }
            else
            {
                if (((q15.Text[q15.Text.Length - 1] == 'ᜀ' || q15.Text[q15.Text.Length - 1] == 'ᜁ' || q15.Text[q15.Text.Length - 1] == 'ᜂ' || q15.Text[q15.Text.Length - 1] == 'ᜒ' || q15.Text[q15.Text.Length - 1] == 'ᜓ' || q15.Text[q15.Text.Length - 1] == '᜔' || q15.Text[q15.Text.Length - 1] == '᜶' || q15.Text[q15.Text.Length - 1] == ' ') && (ch == "ᜒ" || ch == "ᜓ" || ch == "᜔")) || (q15.Text[q15.Text.Length - 1] == ' ' && (ch == " " || ch == "᜶")) || (q15.Text[q15.Text.Length - 1] == '᜶' && ch == "᜶"))
                {
                    q15.Text = q15.Text;
                }
                else
                {
                    q15.Text = q15.Text + ch;
                }
            }
        }
        private void q15Clear()
        {
            q15Verdict.Text = "";
            q15.Text = "Magsulat dito...";
            q15.FontAttributes = FontAttributes.Italic;
            q15.TextColor = Color.FromRgb(127, 127, 127);
        }
        private void q15Back(object sender, EventArgs e)
        {
            q15Verdict.Text = "";
            if (q15.Text != "Magsulat dito...")
            {
                q15.Text = q15.Text.Substring(0, q15.Text.Length - 1);

                if (q15.Text == "")
                {
                    q15.Text = "Magsulat dito...";
                    q15.FontAttributes = FontAttributes.Italic;
                    q15.TextColor = Color.FromRgb(127, 127, 127);
                }
            }
        }

        private async void ProceedClicked(object sender, EventArgs e)
        {
            string scoreText = File.ReadAllText(App.tempFile1);

            var failedPage = new Quiz4FailPage();
            var successPage = new Quiz4SuccessPage();

            int score = 0;
            if (q11.Text == "ᜀᜌ᜔᜶ ᜃᜎ᜔ᜊᜓ᜶")
            {
                score++;

                q11Verdict.Text = "TAMA";
                q11Verdict.TextColor = Color.Green;
            }
            else
            {
                q11Verdict.Text = "MALI";
                q11Verdict.TextColor = Color.Red;
            }
            if (q12.Text == "ᜃᜉᜄ᜔ ᜑᜒᜈ᜔ᜇᜒ ᜋᜓ ᜈᜃᜒᜆ ᜋᜃᜒᜃᜒᜆ ᜋᜓ᜶")
            {
                score++;

                q12Verdict.Text = "TAMA";
                q12Verdict.TextColor = Color.Green;
            }
            else
            {
                q12Verdict.Text = "MALI";
                q12Verdict.TextColor = Color.Red;
            }
            if (q13.Text == "ᜑᜒᜌᜅ᜔ᜑᜒᜌ ᜈᜋᜈ᜔ ᜀᜃᜓ᜶")
            {
                score++;

                q13Verdict.Text = "TAMA";
                q13Verdict.TextColor = Color.Green;
            }
            else
            {
                q13Verdict.Text = "MALI";
                q13Verdict.TextColor = Color.Red;
            }
            if (q14.Text == "ᜑᜓᜏᜄ᜔ ᜃ ᜋᜏᜏᜎᜈ᜔ ᜅ᜔ ᜉᜄ᜔ᜀᜐ᜶")
            {
                score++;

                q14Verdict.Text = "TAMA";
                q14Verdict.TextColor = Color.Green;
            }
            else
            {
                q14Verdict.Text = "MALI";
                q14Verdict.TextColor = Color.Red;
            }
            if (q15.Text == "ᜐᜌᜅ᜔ ᜎᜅ᜔ ᜀᜅ᜔ ᜂᜇᜐ᜔ ᜃᜓ ᜐ ᜁᜌᜓ᜶")
            {
                score++;

                q15Verdict.Text = "TAMA";
                q15Verdict.TextColor = Color.Green;
            }
            else
            {
                q15Verdict.Text = "MALI";
                q15Verdict.TextColor = Color.Red;
            }
            score = score + Int32.Parse(scoreText);
            File.WriteAllText(App.tempFile, score.ToString() + "/15");

            if (score >= 12)
            {
                Record record = new Record()
                {
                    Id = 16,
                    RecordName = "Quiz 4",
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
        private async void BackClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("../");
        }
    }
}