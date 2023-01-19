using Alux.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Alux
{
    public partial class App: Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new ViewingBluetoothDevices();
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
