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

        private void tpicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
            {
                var time = tpicker.Time.Hours;
                Image img = new Image();
                if (time == 1)
                {
                    Labla.Text = "Ночь... Красиво";
                    kartinka.Source = "nuli.jpg";
                }
                else if (time == 2)
                {
                    Labla.Text = "Глубокая ночь, а ты не спишь";
                    kartinka.Source = "nuli.jpg";
                }
                else if (time == 3)
                {
                    Labla.Text = "Глубокая ночь, а ты пьешь чай";
                    kartinka.Source = "nuli.jpg";
                }
                else if (time == 4)
                {
                    Labla.Text = "Глубокая ночь, а ты ещё пьешь энергетик";
                    kartinka.Source = "nuli.jpg";
                }
                else if (time == 5)
                {
                    Labla.Text = "Иди спать, хоспаде";
                    kartinka.Source = "nuli.jpg";
                }
                else if (time == 6)
                {
                    Labla.Text = "Доброе утро?";
                    kartinka.Source = "nuli.jpg";
                }
                else if (time == 7)
                {
                    Labla.Text = "Давай беги к автобусу, а то опоздаешь";
                    kartinka.Source = "nuli.jpg";
                }
                else if (time == 8)
                {
                    Labla.Text = "Первый урок… Нудный, верно?";
                    kartinka.Source = "nuli.jpg";
                }
                else if (time == 9)
                {
                    Labla.Text = "Bruh";
                    kartinka.Source = "nuli.jpg";
                }
                else if (time == 10)
                {
                    Labla.Text = "10 утра… Ужс";
                    kartinka.Source = "nuli.jpg";
                }
                else if (time == 11)
                {
                    Labla.Text = "Ну всё, теперь у меня нет заготовленных текстов, так уж….";
                    kartinka.Source = "nuli.jpg";
                }
                else
                {
                    Labla.Text = "Ничего тут больше не будет";
                    kartinka.Source = "pepe_sad.png";
                }

            }
        }
    }
}