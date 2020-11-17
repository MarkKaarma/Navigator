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
    public partial class Ajaplaan : ContentPage
    {
        public Ajaplaan()
        {
            InitializeComponent();
        }

    }

    private void TimetoChange(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
        {
            var time = TimePicker.Time.Hours;
            if (time == 1)
            {
                Labla.Text = "Ночь... Красиво";
                img = "nuli.jpg";
            }
        }
    }
}