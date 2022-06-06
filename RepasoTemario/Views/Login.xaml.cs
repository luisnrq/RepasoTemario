using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RepasoTemario.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            this.loginBoton.Clicked += LoginBoton_Clicked;
        }

        private async void LoginBoton_Clicked(object sender, EventArgs e)
        {
            Registro view = new Registro();
            await Navigation.PushModalAsync(view);
        }
    }
}