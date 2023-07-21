using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Xamarin.Forms.Internals.Profile;

namespace orangine
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class registro : ContentPage
    {
        string usuario;
        public registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "usuario conectado" + " " + "es:" + "  " + usuario;
            this.usuario = usuario;
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new agua());
        }
        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new american());
        }
        private void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new buzz());
        }
        private void ImageButton_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new citrus());
        }
        private void ImageButton_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new enanitos());
        }
        private void ImageButton_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new energine());
        }

        private void ImageButton_Clicked_6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new free());
        }

        private void ImageButton_Clicked_7(object sender, EventArgs e)
        {
            Navigation.PushAsync(new fresa());
        }

        private void ImageButton_Clicked_8(object sender, EventArgs e)
        {
            Navigation.PushAsync(new guayaco());
        }

        private void ImageButton_Clicked_9(object sender, EventArgs e)
        {
            Navigation.PushAsync(new manzana());
        }
    

        private void ImageButton_Clicked_10(object sender, EventArgs e)
        {
            Navigation.PushAsync(new naranja());
        }

        private void ImageButton_Clicked_11(object sender, EventArgs e)
        {
            Navigation.PushAsync(new pina());
        }

        private void ImageButton_Clicked_12(object sender, EventArgs e)
        {
            Navigation.PushAsync(new mora());
        }

        private void ImageButton_Clicked_13(object sender, EventArgs e)
        {
            Navigation.PushAsync(new mineral());
        }

        private void ImageButton_Clicked_14(object sender, EventArgs e)
        {
            Navigation.PushAsync(new tonica());
        }
    }
}