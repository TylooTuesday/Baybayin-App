﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace baybayinapp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BLesson2 : ContentPage
    {
        public BLesson2()
        {
            InitializeComponent();
        }
        private async void Lesson3Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"../{nameof(BLesson3)}");
        }
    }
}