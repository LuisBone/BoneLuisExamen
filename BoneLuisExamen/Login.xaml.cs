using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BoneLuisExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            //Obtener por pantalla datos ingresados por usuario
            String user = txtUsuario.Text;
            String pass = txtClave.Text;

            //validar los datos
            if (user == "estudiante2020" && pass == "uisrael2020")
            {
                await Navigation.PushAsync(new Registro(user));
            }
            else
            {
                await DisplayAlert("Error", "Es incorrecto el usuario o contraseña.", "ok");
            }
        }
    }
}