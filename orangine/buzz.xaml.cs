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
	public partial class buzz : ContentPage
	{
		public buzz ()
		{
			InitializeComponent ();
		}

        private void btnAgregar_Clicked(object sender, EventArgs e)
        {

        }
    }
}