using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Alux
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BluetoothDeviceCell : ViewCell
	{
		public BluetoothDeviceCell()
		{
			InitializeComponent();

            View = fieldForAll;
		}

        public static readonly BindableProperty DeviceNameProperty =
            BindableProperty.Create("DeviceName", typeof(string), typeof(BluetoothDeviceCell), "");

        public static readonly BindableProperty DeviceAddressProperty =
            BindableProperty.Create("DeviceAddress", typeof(string), typeof(BluetoothDeviceCell), "");

        public string DeviceName
        {
            get { return (string)GetValue(DeviceNameProperty); }
            set { SetValue(DeviceNameProperty, value); }
        }

        public string DeviceAddress
        {
            get { return (string)GetValue(DeviceAddressProperty); }
            set { SetValue(DeviceAddressProperty, value); }
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (BindingContext != null)
            {
                name.Text = DeviceName;
                address.Text = DeviceAddress;
            }
        }
	}
}