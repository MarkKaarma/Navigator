using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigator
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Poroda6 : ContentPage
    {
        public Poroda6()
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
            await Navigation.PushAsync(new Poroda7());
        }

        private async void konec_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Poroda8());
        }
    }
}