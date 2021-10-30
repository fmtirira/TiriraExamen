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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();

        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text;
                string clave = txtClave.Text;
                //Ventana Registro
                if (usuario == "estudiante2021" && clave == "uisrael2021")
                {
                    await Navigation.PushAsync(new Registro(usuario));
                }
                else
                {
                    await DisplayAlert("MENSAJE DE ALERTA", "Usuario o Contraseña Incorrectos", "OK");
                }
            }
            catch (Exception ex)
            {
                
            }

            

        }
    }
}