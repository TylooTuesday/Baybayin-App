//using baybayinapp.ViewModels;
using baybayinapp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace baybayinapp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(TestPage), typeof(TestPage));

            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));

            Routing.RegisterRoute(nameof(CameraPage), typeof(CameraPage));

            Routing.RegisterRoute(nameof(LearnPage), typeof(LearnPage));
            Routing.RegisterRoute(nameof(History), typeof(History));
            Routing.RegisterRoute(nameof(Achievements), typeof(Achievements));

            Routing.RegisterRoute(nameof(LessonsPage), typeof(LessonsPage));
            Routing.RegisterRoute(nameof(ActivitiesPage), typeof(ActivitiesPage));
            Routing.RegisterRoute(nameof(QuizzesPage), typeof(QuizzesPage));

            Routing.RegisterRoute(nameof(Lesson1Page), typeof(Lesson1Page));
            Routing.RegisterRoute(nameof(Lesson1Page2), typeof(Lesson1Page2));
            Routing.RegisterRoute(nameof(Lesson1Page3), typeof(Lesson1Page3));
            Routing.RegisterRoute(nameof(Lesson2Page), typeof(Lesson2Page));
            Routing.RegisterRoute(nameof(Lesson3Page), typeof(Lesson3Page));
            Routing.RegisterRoute(nameof(Lesson4Page), typeof(Lesson4Page));
            Routing.RegisterRoute(nameof(Lesson5Page), typeof(Lesson5Page));
            Routing.RegisterRoute(nameof(Lesson6Page), typeof(Lesson6Page));
            Routing.RegisterRoute(nameof(Lesson7Page), typeof(Lesson7Page));
            Routing.RegisterRoute(nameof(Lesson8Page), typeof(Lesson8Page));
            Routing.RegisterRoute(nameof(Lesson9Page), typeof(Lesson9Page));
            Routing.RegisterRoute(nameof(Lesson10Page), typeof(Lesson10Page));
            Routing.RegisterRoute(nameof(Lesson11Page), typeof(Lesson11Page));
            Routing.RegisterRoute(nameof(Lesson12Page), typeof(Lesson12Page));

            Routing.RegisterRoute(nameof(Activity1Page), typeof(Activity1Page));
            Routing.RegisterRoute(nameof(Activity2Page), typeof(Activity2Page));
            Routing.RegisterRoute(nameof(Activity3Page), typeof(Activity3Page));
            Routing.RegisterRoute(nameof(Activity4Page), typeof(Activity4Page));
            Routing.RegisterRoute(nameof(Activity5Page), typeof(Activity5Page));
            Routing.RegisterRoute(nameof(Activity6Page), typeof(Activity6Page));
            Routing.RegisterRoute(nameof(Activity7Page), typeof(Activity7Page));
            Routing.RegisterRoute(nameof(Activity8Page), typeof(Activity8Page));
            Routing.RegisterRoute(nameof(Activity9Page), typeof(Activity9Page));
            Routing.RegisterRoute(nameof(Activity10Page), typeof(Activity10Page));
            Routing.RegisterRoute(nameof(Activity11Page), typeof(Activity11Page));
            Routing.RegisterRoute(nameof(Activity12Page), typeof(Activity12Page));

            Routing.RegisterRoute(nameof(Quiz1Page), typeof(Quiz1Page));
            Routing.RegisterRoute(nameof(Quiz2Page), typeof(Quiz2Page));
            Routing.RegisterRoute(nameof(Quiz3Page), typeof(Quiz3Page));
            Routing.RegisterRoute(nameof(Quiz4Page), typeof(Quiz4Page));
            Routing.RegisterRoute(nameof(Quiz4Page2), typeof(Quiz4Page2));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//HomePage");
        }
    }
}
