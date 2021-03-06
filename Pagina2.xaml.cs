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
    public partial class Pagina2 : ContentPage
    {
        public Pagina2()
        {
            InitializeComponent();
        }

        private void Aceptar_Clicked(object sender, EventArgs e)
        {
            var Resultado = Int32.Parse(resultado.Text);//RECUPERANDO DATOS DEL ENTRY DEL RESULTADDO

            Resultado -= 365;//RESTANDO 365 AL RESUTLADO DEL USUARIO


            var Cadena = Resultado.ToString();//CONVIRTIENDO EL RESULTADO A CADENA Y ASIGNANDOLO A UNA NUEVA VARIABLE

            dia.Text = Cadena.Substring(0, 1);
            mes.Text = Cadena.Substring(Cadena.Length - 2, 2);//IMPRIMIENDO LOS RESULTADOS DE LA OPERACION

        }
    }

}