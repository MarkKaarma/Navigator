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
    public partial class Poroda8 : ContentPage
    {
        public Poroda8()
        {
            InitializeComponent();
        }

        private async void obratno_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
            await Navigation.PushAsync(new MainPage());
            
        }
    }
}