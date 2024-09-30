using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalcularIMC_EESA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var Altura = double.Parse(altura.Text);//Altura es la lógica, y altura.Text es lo que llama la vista
            var Peso = double.Parse(peso.Text);
            var IMC = Peso /(Altura*Altura);

            imc.Text = IMC.ToString();
        }
    }
}
