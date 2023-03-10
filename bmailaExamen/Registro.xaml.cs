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



        private void btnGuardar_Clicked(object sender, EventArgs e)
       

        {
            Navigation.PushAsync(new Resumen(lblUsuario.Text, txtNombre.Text, txtPagoT.Text));
            DisplayAlert("felicidades ", "se guardo con exito", "ACEPTAR");

        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtMonto.Text) < 1)
                {
                    DisplayAlert("Error", "ingrese un monto mayor  a 1", "cerrar");
                }
                if (Convert.ToDouble(txtMonto.Text) > 3999)
                {
                    DisplayAlert("Error", "ingrese un monto menor  a 4000", "cerrar");
                }
            }
            catch (Exception )
            {

                throw;
            }
            try
            {
                double montoInicial = Convert.ToDouble(txtMonto.Text);
                double Pago = ((4000 - montoInicial) / 5) + (4000*0.05);
                double pagoT = Pago * 5 + montoInicial;
                txtPago.Text = Pago.ToString();
                txtPagoT.Text = pagoT.ToString();

            }
            catch (Exception ex)
            {

                DisplayAlert("Alerta", ex.ToString(), "Cerrar");

            }

        }

        private void txtMonto_TextChanged(object sender, TextChangedEventArgs e)
        {
          

        }
    }
}