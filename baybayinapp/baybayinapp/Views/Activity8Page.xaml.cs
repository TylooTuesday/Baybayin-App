using baybayinapp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace baybayinapp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activity8Page : ContentPage
    {
        public Activity8Page()
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

            a8q1Active = new Command(q1Active);
            a8q2Active = new Command(q2Active);
            a8q3Active = new Command(q3Active);
            a8q4Active = new Command(q4Active);
            a8q5Active = new Command(q5Active);

            a8q1Type = new Command<string>(q1Append);
            a8q1Clear = new Command(q1Clear);
            a8q2Type = new Command<string>(q2Append);
            a8q2Clear = new Command(q2Clear);
            a8q3Type = new Command<string>(q3Append);
            a8q3Clear = new Command(q3Clear);
            a8q4Type = new Command<string>(q4Append);
            a8q4Clear = new Command(q4Clear);
            a8q5Type = new Command<string>(q5Append);
            a8q5Clear = new Command(q5Clear);

            BindingContext = this;
        }

        public Command a8q1Active { get; }
        public Command a8q2Active { get; }
        public Command a8q3Active { get; }
        public Command a8q4Active { get; }
        public Command a8q5Active { get; }

        private void q1Active()
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
        private void q2Active()
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
        private void q3Active()
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
        private void q4Active()
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
        private void q5Active()
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
        public Command<string> a8q1Type { get; }
        public Command a8q1Clear { get; }
        public Command<string> a8q2Type { get; }
        public Command a8q2Clear { get; }
        public Command<string> a8q3Type { get; }
        public Command a8q3Clear { get; }
        public Command<string> a8q4Type { get; }
        public Command a8q4Clear { get; }
        public Command<string> a8q5Type { get; }
        public Command a8q5Clear { get; }

        private void q1Append(string ch)
        {
            q1Verdict.Text = "";

            if (q1.Text == "Magsulat dito..." && (ch != "ᜒ" || ch != "ᜓ" || ch != "᜔" || ch != " " || ch != "᜶"))
            {
                q1.Text = ch;
                q1.FontAttributes = FontAttributes.None;
                q1.SetAppThemeColor(Label.TextColorProperty, Color.FromHex("#505050"), Color.FromHex("#eeeeee"));
            }
            else
            {
                if (((q1.Text[q1.Text.Length - 1] == 'ᜀ' || q1.Text[q1.Text.Length - 1] == 'ᜁ' || q1.Text[q1.Text.Length - 1] == 'ᜂ' || q1.Text[q1.Text.Length - 1] == 'ᜒ' || q1.Text[q1.Text.Length - 1] == 'ᜓ' || q1.Text[q1.Text.Length - 1] == '᜔' || q1.Text[q1.Text.Length - 1] == '᜶' || q1.Text[q1.Text.Length - 1] == ' ') && (ch == "ᜒ" || ch == "ᜓ" || ch == "᜔")) || (q1.Text[q1.Text.Length - 1] == ' ' && (ch == " " || ch == "᜶")) || (q1.Text[q1.Text.Length - 1] == '᜶' && ch == "᜶"))
                {
                    q1.Text = q1.Text;
                }
                else
                {
                    q1.Text = q1.Text + ch;
                }
            }
        }
        private void q1Clear()
        {
            q1Verdict.Text = "";
            q1.Text = "Magsulat dito...";
            q1.FontAttributes = FontAttributes.Italic;
            q1.TextColor = Color.FromRgb(127, 127, 127);
        }
        private void q1Back(object sender, EventArgs e)
        {
            q1Verdict.Text = "";
            if (q1.Text != "Magsulat dito...")
            {
                q1.Text = q1.Text.Substring(0, q1.Text.Length - 1);

                if (q1.Text == "")
                {
                    q1.Text = "Magsulat dito...";
                    q1.FontAttributes = FontAttributes.Italic;
                    q1.TextColor = Color.FromRgb(127, 127, 127);
                }
            }
        }

        private void q2Append(string ch)
        {
            q2Verdict.Text = "";
            if (q2.Text == "Magsulat dito..." && (ch != "ᜒ" || ch != "ᜓ" || ch != "᜔" || ch != " " || ch != "᜶"))
            {
                q2.Text = ch;
                q2.FontAttributes = FontAttributes.None;
                q2.SetAppThemeColor(Label.TextColorProperty, Color.FromHex("#505050"), Color.FromHex("#eeeeee"));
            }
            else
            {
                if (((q2.Text[q2.Text.Length - 1] == 'ᜀ' || q2.Text[q2.Text.Length - 1] == 'ᜁ' || q2.Text[q2.Text.Length - 1] == 'ᜂ' || q2.Text[q2.Text.Length - 1] == 'ᜒ' || q2.Text[q2.Text.Length - 1] == 'ᜓ' || q2.Text[q2.Text.Length - 1] == '᜔' || q2.Text[q2.Text.Length - 1] == '᜶' || q2.Text[q2.Text.Length - 1] == ' ') && (ch == "ᜒ" || ch == "ᜓ" || ch == "᜔")) || (q2.Text[q2.Text.Length - 1] == ' ' && (ch == " " || ch == "᜶")) || (q2.Text[q2.Text.Length - 1] == '᜶' && ch == "᜶"))
                {
                    q2.Text = q2.Text;
                }
                else
                {
                    q2.Text = q2.Text + ch;
                }
            }
        }
        private void q2Clear()
        {
            q2Verdict.Text = "";
            q2.Text = "Magsulat dito...";
            q2.FontAttributes = FontAttributes.Italic;
            q2.TextColor = Color.FromRgb(127, 127, 127);
        }
        private void q2Back(object sender, EventArgs e)
        {
            q2Verdict.Text = "";
            if (q2.Text != "Magsulat dito...")
            {
                q2.Text = q2.Text.Substring(0, q2.Text.Length - 1);

                if (q2.Text == "")
                {
                    q2.Text = "Magsulat dito...";
                    q2.FontAttributes = FontAttributes.Italic;
                    q2.TextColor = Color.FromRgb(127, 127, 127);
                }
            }
        }

        private void q3Append(string ch)
        {
            q3Verdict.Text = "";
            if (q3.Text == "Magsulat dito..." && (ch != "ᜒ" || ch != "ᜓ" || ch != "᜔" || ch != " " || ch != "᜶"))
            {
                q3.Text = ch;
                q3.FontAttributes = FontAttributes.None;
                q3.SetAppThemeColor(Label.TextColorProperty, Color.FromHex("#505050"), Color.FromHex("#eeeeee"));
            }
            else
            {
                if (((q3.Text[q3.Text.Length - 1] == 'ᜀ' || q3.Text[q3.Text.Length - 1] == 'ᜁ' || q3.Text[q3.Text.Length - 1] == 'ᜂ' || q3.Text[q3.Text.Length - 1] == 'ᜒ' || q3.Text[q3.Text.Length - 1] == 'ᜓ' || q3.Text[q3.Text.Length - 1] == '᜔' || q3.Text[q3.Text.Length - 1] == '᜶' || q3.Text[q3.Text.Length - 1] == ' ') && (ch == "ᜒ" || ch == "ᜓ" || ch == "᜔")) || (q3.Text[q3.Text.Length - 1] == ' ' && (ch == " " || ch == "᜶")) || (q3.Text[q3.Text.Length - 1] == '᜶' && ch == "᜶"))
                {
                    q3.Text = q3.Text;
                }
                else
                {
                    q3.Text = q3.Text + ch;
                }
            }
        }
        private void q3Back(object sender, EventArgs e)
        {
            q3Verdict.Text = "";
            if (q3.Text != "Magsulat dito...")
            {
                q3.Text = q3.Text.Substring(0, q3.Text.Length - 1);

                if (q3.Text == "")
                {
                    q3.Text = "Magsulat dito...";
                    q3.FontAttributes = FontAttributes.Italic;
                    q3.TextColor = Color.FromRgb(127, 127, 127);
                }
            }
        }
        private void q3Clear()
        {
            q3Verdict.Text = "";
            q3.Text = "Magsulat dito...";
            q3.FontAttributes = FontAttributes.Italic;
            q3.TextColor = Color.FromRgb(127, 127, 127);
        }

        private void q4Append(string ch)
        {
            q4Verdict.Text = "";
            if (q4.Text == "Magsulat dito..." && (ch != "ᜒ" || ch != "ᜓ" || ch != "᜔" || ch != " " || ch != "᜶"))
            {
                q4.Text = ch;
                q4.FontAttributes = FontAttributes.None;
                q4.SetAppThemeColor(Label.TextColorProperty, Color.FromHex("#505050"), Color.FromHex("#eeeeee"));
            }
            else
            {
                if (((q4.Text[q4.Text.Length - 1] == 'ᜀ' || q4.Text[q4.Text.Length - 1] == 'ᜁ' || q4.Text[q4.Text.Length - 1] == 'ᜂ' || q4.Text[q4.Text.Length - 1] == 'ᜒ' || q4.Text[q4.Text.Length - 1] == 'ᜓ' || q4.Text[q4.Text.Length - 1] == '᜔' || q4.Text[q4.Text.Length - 1] == '᜶' || q4.Text[q4.Text.Length - 1] == ' ') && (ch == "ᜒ" || ch == "ᜓ" || ch == "᜔")) || (q4.Text[q4.Text.Length - 1] == ' ' && (ch == " " || ch == "᜶")) || (q4.Text[q4.Text.Length - 1] == '᜶' && ch == "᜶"))
                {
                    q4.Text = q4.Text;
                }
                else
                {
                    q4.Text = q4.Text + ch;
                }
            }
        }
        private void q4Clear()
        {
            q4Verdict.Text = "";
            q4.Text = "Magsulat dito...";
            q4.FontAttributes = FontAttributes.Italic;
            q4.TextColor = Color.FromRgb(127, 127, 127);
        }
        private void q4Back(object sender, EventArgs e)
        {
            q4Verdict.Text = "";
            if (q4.Text != "Magsulat dito...")
            {
                q4.Text = q4.Text.Substring(0, q4.Text.Length - 1);

                if (q4.Text == "")
                {
                    q4.Text = "Magsulat dito...";
                    q4.FontAttributes = FontAttributes.Italic;
                    q4.TextColor = Color.FromRgb(127, 127, 127);
                }
            }
        }

        private void q5Append(string ch)
        {
            q5Verdict.Text = "";
            if (q5.Text == "Magsulat dito..." && (ch != "ᜒ" || ch != "ᜓ" || ch != "᜔" || ch != " " || ch != "᜶"))
            {
                q5.Text = ch;
                q5.FontAttributes = FontAttributes.None;
                q5.SetAppThemeColor(Label.TextColorProperty, Color.FromHex("#505050"), Color.FromHex("#eeeeee"));
            }
            else
            {
                if (((q5.Text[q5.Text.Length - 1] == 'ᜀ' || q5.Text[q5.Text.Length - 1] == 'ᜁ' || q5.Text[q5.Text.Length - 1] == 'ᜂ' || q5.Text[q5.Text.Length - 1] == 'ᜒ' || q5.Text[q5.Text.Length - 1] == 'ᜓ' || q5.Text[q5.Text.Length - 1] == '᜔' || q5.Text[q5.Text.Length - 1] == '᜶' || q5.Text[q5.Text.Length - 1] == ' ') && (ch == "ᜒ" || ch == "ᜓ" || ch == "᜔")) || (q5.Text[q5.Text.Length - 1] == ' ' && (ch == " " || ch == "᜶")) || (q5.Text[q5.Text.Length - 1] == '᜶' && ch == "᜶"))
                {
                    q5.Text = q5.Text;
                }
                else
                {
                    q5.Text = q5.Text + ch;
                }
            }
        }
        private void q5Clear()
        {
            q5Verdict.Text = "";
            q5.Text = "Magsulat dito...";
            q5.FontAttributes = FontAttributes.Italic;
            q5.TextColor = Color.FromRgb(127, 127, 127);
        }
        private void q5Back(object sender, EventArgs e)
        {
            q5Verdict.Text = "";
            if (q5.Text != "Magsulat dito...")
            {
                q5.Text = q5.Text.Substring(0, q5.Text.Length - 1);

                if (q5.Text == "")
                {
                    q5.Text = "Magsulat dito...";
                    q5.FontAttributes = FontAttributes.Italic;
                    q5.TextColor = Color.FromRgb(127, 127, 127);
                }
            }
        }

        // next page
        private async void ProceedClicked(object sender, EventArgs e)
        {
            var failedPage = new ActivityFailedPage();
            var successPage = new Activity8SuccessPage();

            int score = 0;
            if (q1.Text == "ᜉᜄ᜔ᜁᜈᜓᜋ᜔")
            {
                score++;

                q1Verdict.Text = "TAMA";
                q1Verdict.TextColor = Color.Green;
            }
            else
            {
                q1Verdict.Text = "MALI";
                q1Verdict.TextColor = Color.Red;
            }
            if (q2.Text == "ᜆᜄ᜔ᜀᜇᜏ᜔")
            {
                score++;

                q2Verdict.Text = "TAMA";
                q2Verdict.TextColor = Color.Green;
            }
            else
            {
                q2Verdict.Text = "MALI";
                q2Verdict.TextColor = Color.Red;
            }
            if (q3.Text == "ᜋᜄ᜔ᜁᜐ")
            {
                score++;

                q3Verdict.Text = "TAMA";
                q3Verdict.TextColor = Color.Green;
            }
            else
            {
                q3Verdict.Text = "MALI";
                q3Verdict.TextColor = Color.Red;
            }
            if (q4.Text == "ᜀᜈᜓᜀᜈᜓ")
            {
                score++;

                q4Verdict.Text = "TAMA";
                q4Verdict.TextColor = Color.Green;
            }
            else
            {
                q4Verdict.Text = "MALI";
                q4Verdict.TextColor = Color.Red;
            }
            if (q5.Text == "ᜈᜄ᜔ᜂᜎᜆ᜔")
            {
                score++;

                q5Verdict.Text = "TAMA";
                q5Verdict.TextColor = Color.Green;
            }
            else
            {
                q5Verdict.Text = "MALI";
                q5Verdict.TextColor = Color.Red;
            }
            if (score >= 5)
            {
                Record record = new Record()
                {
                    Id = 8,
                    RecordName = "Activity 8",
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