using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace orangine
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            String usuario = "jaimico";
            String contraseña = "1234";
            if (txtUsuario.Text == usuario && txtContraseña.Text == contraseña)
            {
                Navigation.PushAsync(new registro(usuario));
            }
            else
            {
                DisplayAlert("ERROR", " usuario y contaseña incorrectos ", " cerrar ");
            }
        }
    }
}