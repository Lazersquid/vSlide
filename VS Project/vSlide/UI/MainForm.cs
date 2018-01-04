using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Immutable;

namespace vSlide
{
    public partial class MainForm : Form
    {
        protected SliderFeeder feeder;
        protected Timer updateTimer;

        protected bool IsFeeding
        {
            get { return updateTimer.Enabled; }
            set
            {
                if (value == true && feeder.State != FeederState.Ready)
                    throw new InvalidOperationException(string.Format(
                        "Can't start feeding, feeder is in state {0}!", feeder.State));

                updateTimer.Enabled = value;

                UpdateFeedingButton();
                UpdatePanelEnables();
                if (IsFeeding)
                    UpdateFeederConfiguration();
                else
                    feeder.SliderValue = 0;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            updateTimer = new Timer { Interval = 5 };
            feeder = new SliderFeeder();

            vjoyInfoBox.IsVjoyInstalled = feeder.DriverState != DriverState.VJoyNotInstalled;
            vjoyInfoBox.VjoyVersion = feeder.VjoyDriverVersion;
            vjoyInfoBox.VjoyDllVersion = feeder.VjoyDllVersion;

            updateTimer.Tick += UpdateTimer_Tick;
            devicePanel.AcquireButtonClick += DevicePanel_AcquireButtonClick;
            feeder.SliderValueChanged += Feeder_SliderValueChanged;
            feeder.OwnedDeviceIdChanged += Feeder_OwnedDeviceIdChanged;
            UpdateUI();

            if (feeder.State != FeederState.DriverError
                && feeder.GetAcquirableVjoyDevices().Count > 0)
            {
                feeder.AcquireVjoyDevice();
            }

            sliderModeComboBox.DisplayMember = "DisplayString";
            sliderModeComboBox.Items.Add(new DefaultSliderMode());
            sliderModeComboBox.Items.Add(new PingPongLerpSliderMode(10, 0.01M));
            sliderModeComboBox.SelectionChangeCommitted += SliderModeComboBox_SelectionChangeCommitted;
            sliderModeComboBox.SelectedIndex = 0;
        }

        private void SliderModeComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            feeder.SliderMode = (ISliderMode)sliderModeComboBox.SelectedItem;
        }

        protected void FeederTick(int elapsedMs)
        {
            feeder.Update(elapsedMs);
        }

        #region feeder configuration updating
        protected void UpdateFeederConfiguration()
        {
            UpdateFeederManipulators();
            UpdateFeederLevels();
        }
        protected void UpdateFeederManipulators()
        {
            var newManipulators = manipulatorPanel.CreateManipulators().ToImmutableArray();
            feeder.Manipulators = newManipulators;
        }
        protected void UpdateFeederLevels()
        {
            var newLevels = sliderLevelsPanel.CreateSliderLevels();
            feeder.SliderLevels = newLevels;
        }
        #endregion

        #region ui updating
        protected void UpdateUI()
        {
            UpdateDevicePanel();
            UpdateManipulatorPanel();
            UpdateFeedingButton();
            UpdateSliderDisplay();
            UpdateLevelsPanel();
        }

        protected void UpdatePanelEnables()
        {
            UpdateManipulatorPanelEnabled();
            UpdateDevicePanelEnabled();
            UpdateSliderDisplayEnabled();
            UpdateLevelsPanelEnabled();
        }

        #region FeedingButton
        protected void UpdateFeedingButton()
        {
            feedingButton.Enabled = (feeder.State == FeederState.Ready);

            if (updateTimer.Enabled)
                feedingButton.Text = "Stop";
            else
                feedingButton.Text = "Start";
        }
        #endregion

        #region ManipulatorPanel
        protected void UpdateManipulatorPanel()
        {
            UpdateManipulatorPanelEnabled();
        }

        protected void UpdateManipulatorPanelEnabled()
        {
            if (feeder.State == FeederState.DriverError)
            {
                manipulatorPanel.Enabled = false;
                return;
            }
            manipulatorPanel.Enabled = !IsFeeding;
        }
        #endregion

        #region DevicePanel
        protected void UpdateDevicePanel()
        {
            UpdateDevicePanelEnabled();
            if(feeder.State != FeederState.DriverError)
            {
                UpdateDeviceList();
                UpdateAcquiredDevice();
            }
        }

        protected void UpdateDevicePanelEnabled()
        {
            if (feeder.State == FeederState.DriverError)
            {
                devicePanel.Enabled = false;
                return;
            }
            devicePanel.Enabled = !IsFeeding;
        }

        protected void UpdateDeviceList()
        {
            var devices = feeder.GetAcquirableVjoyDevices();
            devicePanel.DeviceIds = devices.ToArray();
        }

        protected void UpdateAcquiredDevice()
        {
            devicePanel.AcquiredDeviceId = feeder.OwnedDeviceId;
        }
        #endregion

        #region SliderDisplay
        public void UpdateSliderDisplay()
        {
            UpdateSliderDisplayEnabled();
            UpdateSliderDisplayValue();
        }

        public void UpdateSliderDisplayEnabled()
        {
            if (feeder.State == FeederState.DriverError)
            {
                sliderView.Enabled = false;
                return;
            }
            sliderView.Enabled = IsFeeding;
        }

        public void UpdateSliderDisplayValue()
        {
            if (feeder.State == FeederState.DriverError) return;
            if (sliderView.SliderValue != feeder.SliderValue)
                sliderView.SetValue(feeder.SliderValue, false);
        }
        #endregion

        #region SliderLevels
        public void UpdateLevelsPanel()
        {
            UpdateLevelsPanelEnabled();
        }

        public void UpdateLevelsPanelEnabled()
        {
            if (feeder.State == FeederState.DriverError)
            {
                sliderLevelsPanel.Enabled = false;
                return;
            }
            sliderLevelsPanel.Enabled = !IsFeeding;
        }
        #endregion
        #endregion

        #region event callbacks
        protected void FeedingButton_Click(object sender, EventArgs e)
        {
            IsFeeding = !IsFeeding;
        }

        private void Feeder_OwnedDeviceIdChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void Feeder_SliderValueChanged(object sender, EventArgs e)
        {
            UpdateSliderDisplayValue();
        }

        private void SliderView_ValueChanged(object sender, EventArgs e)
        {
            if (!IsFeeding) throw new InvalidOperationException();
            feeder.SliderValue = sliderView.SliderValue;
        }

        private void DevicePanel_AcquireButtonClick(object sender, EventArgs e)
        {
            var deviceId = devicePanel.SelectedDeviceId;

            // create error msg box if device is not acquirable
            if(!feeder.IsDeviceAcquirable(deviceId))
            {
                string msg;
                if (!feeder.HasDeviceSlider(deviceId))
                    msg = string.Format("Device {0} has no slider axis!", deviceId);
                else
                    msg = string.Format("Device {0} is in state '{1}'", deviceId, feeder.GetDeviceStatus(deviceId));
                MessageBox.Show(
                    string.Format(msg, deviceId, feeder.GetDeviceStatus(deviceId)),
                    "Can't acquire device",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // relinquish old device and acquire new one
            if (feeder.State == FeederState.Ready)
                feeder.RelinquishOwnedVJoyDevices();
            feeder.AcquireVjoyDevice(deviceId);
        }

        protected void UpdateTimer_Tick(object sender, EventArgs e)
        {
            if (feeder.State != FeederState.Ready)
            {
                IsFeeding = false;
                throw new InvalidOperationException(string.Format(
                    "Can't execute {0}: Feeder state is {1}!", nameof(UpdateTimer_Tick), feeder.State));
            }

            FeederTick(updateTimer.Interval);
        }

        protected void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (feeder.State != FeederState.DriverError)
            {
                feeder.RelinquishOwnedVJoyDevices();
            }
            Logger.Flush();
        }
        #endregion
    }
}
