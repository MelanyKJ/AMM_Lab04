using Ejercicio_02.Services;
using Ejercicio_02.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio_02
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            MainPage = new NavigationPage(new MainPage());
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
