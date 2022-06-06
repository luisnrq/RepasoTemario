using RepasoTemario.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RepasoTemario
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new PaginaEventos();
            //MainPage = new Prueba();
            //MainPage = new Registro();
            //MainPage = new Login();
            MainPage = new TabbedPage1();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
