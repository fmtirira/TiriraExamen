using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiriraExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        double monto;
        double calcular;
        double totalPagar;
        public Registro(String usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
        }



        private void txtMonto_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                monto = Convert.ToDouble(txtMonto.Text);

                //aceptar valores de 1-10
                if (monto < 1)
                {
                    DisplayAlert("MENSAJE DE ALERTA", "No se permite valores menores de 1", "OK");
                    txtMonto.Text = "";
                }
                else
                {
                    if (monto >= 1800)
                    {
                        DisplayAlert("MENSAJE DE ALERTA", "No se permite valores mayores de 1800", "OK");
                        txtMonto.Text = "";
                    }
                }

            }
            catch (Exception ex)
            {

            }
        }
        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                calcular = ((1800 - monto) / 3) + (1800 * 0.05);
                totalPagar = 1800 - monto;
                txtTotal.Text = Convert.ToString(totalPagar);
                txtMensual.Text = Convert.ToString(calcular);

            }
            catch (Exception ex)
            {

            }

        }
        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string usuario = lblUsuario.Text;
                string totalPagar = txtTotal.Text;
                string mensual = txtMensual.Text;
                await DisplayAlert("INFORMACIÓN", "Elemento Guardado con Éxito", "OK");
                await Navigation.PushAsync(new Resumen(usuario, nombre,totalPagar,mensual));
            }
            catch (Exception ex)
            {

            }
            
        }

  
    }
}