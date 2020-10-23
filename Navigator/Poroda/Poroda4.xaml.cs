﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigator
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Poroda4 : ContentPage
    {
        public Poroda4()
        {
            InitializeComponent();
        }

        private async void obratno_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
            await Navigation.PushAsync(new MainPage());
        }

        private async void sled_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Poroda5());
        }

        private async void konec_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Poroda8());
        }
    }
}