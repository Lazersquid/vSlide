using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vSlide
{
    public partial class DevicePanel : UserControl
    {
        public event EventHandler AcquireButtonClick;

        public uint[] DeviceIds
        {
            set
            {
                if (value == null)
                    throw new ArgumentNullException();

                deviceListCombobox.Items.Clear();
                for (int i = 0; i < value.Length; i++)
                {
                    deviceListCombobox.Items.Add(value[i]);
                }

                // select first item if list is not empty
                if (deviceListCombobox.Items.Count > 0)
                    deviceListCombobox.SelectedIndex = 0;

                // disable acquire button if device list is empty
                acquireButton.Enabled = deviceListCombobox.Items.Count <= 0 ? false : true;
            }
        }
        public uint AcquiredDeviceId
        {
            set
            {
                if (value > 16)
                    throw new ArgumentOutOfRangeException();

                acquiredDeviceIdLabel.Text = value == 0 ? "-" : value.ToString();
            }
        }
        public uint SelectedDeviceId
        {
            get
            {
                if (deviceListCombobox.SelectedItem == null)
                    return 0;

                var selectedItem = deviceListCombobox.SelectedItem;
                if (!(selectedItem is uint))
                    throw new ArgumentOutOfRangeException(
                        string.Format("Can't return selected device id: Selected item {0} is of type {1}!",
                        selectedItem, selectedItem.GetType()));

                return (uint)selectedItem;
            }
        }

        public DevicePanel()
        {
            InitializeComponent();

            DeviceIds = new uint[0];
            acquireButton.Click += AcquireButton_Click;
        }

        protected void AcquireButton_Click(object sender, EventArgs e)
        {
            if (AcquireButtonClick != null)
                AcquireButtonClick(this, e);
        }
    }
}
