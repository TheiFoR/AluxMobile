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

			int bluetoothDeviceCount = (int)adapter.BondedDevices.LongCount();

			List<BluetoothDevice> items = new List<BluetoothDevice>();

			for (int i = 0; i < bluetoothDeviceCount; ++i)
			{
				items.Add(new BluetoothDevice { name = adapter.BondedDevices.ElementAt(i).Name, description = adapter.BondedDevices.ElementAt(i).Address});
			}
			listOfDevices.ItemsSource = items;
		}
    }
}