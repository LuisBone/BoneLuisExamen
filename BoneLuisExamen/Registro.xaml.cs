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
    public partial class Registro : ContentPage
    {
        public double costoAprox = 1800.0;
        public double cuotaTotal;
        public string usuario;

        public Registro(String user)
        {
            InitializeComponent();
            lblTitulo.Text = "conectado: " + user;
            this.usuario = user;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
                
            double cuotaInicial = Convert.ToDouble(txtMonto.Text);
            if (cuotaInicial >= 1801)
            {
                DisplayAlert("Error", "Cuota supera monto total", "ok");
                return;
            }
            double cuotaMes = ((this.costoAprox - cuotaInicial)/3)*1.05;
            this.cuotaTotal = cuotaMes*3;
            txtPago.Text = cuotaMes.ToString();

        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {   

            await Navigation.PushAsync(new Resumen(this.usuario,txtNombre.Text,this.cuotaTotal));
        }
    }
}