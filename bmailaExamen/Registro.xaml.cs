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
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
        }

        private void btnSiguiente_Clicked(object sender, EventArgs e)
        {
            
        }

        private void txtMontoI_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Resumen());
        }
    }
}