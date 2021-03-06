using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mi_Primera_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina1 : ContentPage
    {
        public Pagina1()
        {
            InitializeComponent();
        }

        private void bontonAceptar_Clicked(object sender, EventArgs e)

        {
            var Resultado = (resultado.Text);//RECUPERANDO EL TEXTO INGRESADO A TRAVES DEL ENTRY

            Resultado = Resultado.Remove(Resultado.Length - 1, 1);//QUITANDOLE EL ULTIMO DIGITO A LA CANTIDAD
            

            var numero = Int32.Parse(Resultado);// CONVIRTIENDO LA CANTIDAD A ENTER

            numero = numero - 4;

            numero2.Text = numero.ToString();//IMPRIMIENDO EL RESULTADO
     
            

        }
    }
}