using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigator.Dopolnenie
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Carusel : CarouselPage
    {
        public Carusel()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Textis1.IsVisible = true;
            Textis11.IsVisible = true;
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            Textis2.IsVisible = true;
            Textis21.IsVisible = true;
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            Textis3.IsVisible = true;
            Textis31.IsVisible = true;
        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            Textis4.IsVisible = true;
            Textis41.IsVisible = true;
        }

        private async void uril1_Clicked(object sender, EventArgs e)
        {
            Uri url = new Uri("https://brainapps.ru/test/temperament");
            await Xamarin.Essentials.Browser.OpenAsync(url);
        }

        private async void uril2_Clicked(object sender, EventArgs e)
        {
            Uri url = new Uri("https://brainapps.ru/test/temperament");
            await Xamarin.Essentials.Browser.OpenAsync(url);
        }

        private async void uril3_Clicked(object sender, EventArgs e)
        {
            Uri url = new Uri("https://brainapps.ru/test/temperament");
            await Xamarin.Essentials.Browser.OpenAsync(url);
        }

        private async void uril4_Clicked(object sender, EventArgs e)
        {
            Uri url = new Uri("https://brainapps.ru/test/temperament");
            await Xamarin.Essentials.Browser.OpenAsync(url);
        }
    }
}