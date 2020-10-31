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
    public partial class Resumen : ContentPage
    {
        public Resumen(string user, string nombre, double total)
        {
            InitializeComponent();
            lblTitulo.Text = "conectado: " + user;
            txtNombreEstudiante.Text = nombre;
            txtTotal.Text = total.ToString();
        }
    }
}