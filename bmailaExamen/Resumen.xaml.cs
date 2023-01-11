using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace bmailaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombre, string total)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
            txtNombre.Text = nombre;
            txtTotal.Text = total;
        }


        private void btnAcercade_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("App Realizado por ", "Byron Maila 9no A", "ACEPTAR");

        }
    }
}