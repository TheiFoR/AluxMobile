using Plugin.BluetoothClassic.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Alux.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ViewingBluetoothDevices : ContentPage
	{
		public ViewingBluetoothDevices ()
		{
			InitializeComponent();


			FillBondedDevices();
		}

        private void FillBondedDevices()
        {
			IBluetoothAdapter adapter = DependencyService.Resolve<IBluetoothAdapter>();
			stackForDevices.ItemsSource = adapter.BondedDevices;
        }
    }
}