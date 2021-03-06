using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mi_Primera_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private async void boton1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pagina1());
        }

        private async void boton2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pagina2());
        }

        
    }
}
