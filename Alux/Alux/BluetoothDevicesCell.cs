using Xamarin.Forms;

namespace Alux
{
    public class BluetoothDevicesCell: ViewCell
    {
        BoxView backgroundColor;
        Label name;
        Label address;
        Grid field;
        public BluetoothDevicesCell()
        {
            backgroundColor = new BoxView { BackgroundColor = Color.White };
            name = new Label();
            address = new Label();
            field = new Grid
            {
                RowDefinitions = {
                new RowDefinition{ Height = GridLength.Auto },
                new RowDefinition{ Height = GridLength.Auto }
            }
            };
            field.Children.Add(name, 0, 0);
            field.Children.Add(address, 0, 1);

            View = field;
        }

        public static readonly BindableProperty DeviceNameProperty =
            BindableProperty.Create("DeviceName", typeof(string), typeof(BluetoothDevicesCell), "");

        public static readonly BindableProperty DeviceAddressProperty =
            BindableProperty.Create("DeviceAddress", typeof(string), typeof(BluetoothDevicesCell), "");

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
