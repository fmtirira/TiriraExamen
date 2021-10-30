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
    public partial class Resumen : ContentPage
    {
        public Resumen(String usuario, String nombre, String totalPagar, String mensual)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
            txtNombre.Text = nombre;
            txtMensual.Text = mensual;
            txtTotal.Text = totalPagar;

        }
    }
}