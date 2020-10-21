using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Navigator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private  async void poroda1_Clicked(object sender, EventArgs e) // Для создания Навигатора. Нужно async, для работы. Также PushAsync создает "новую" страницу и добавляет стрелку обратно, т.е в прошлую страницу
        {
            await Navigation.PushAsync(new Poroda1());
        }

        private async void poroda2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Poroda2());
        }

        private async void poroda3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Poroda3());
        }

        private async void poroda4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Poroda4());
        }

        private async void poroda5_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Poroda5());
        }

        private async void poroda6_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Poroda6());
        }

        private async void poroda7_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Poroda7());
        }

        private async void poroda8_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Poroda8());
        }

        private async void dopol_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Dop());
        }
    }
}
