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
    public partial class Quiz1FailPage : ContentPage
    {
        public Quiz1FailPage()
        {
            InitializeComponent();
        }
        private async void BackClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}