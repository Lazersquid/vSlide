using System;
using System.Windows.Forms;
using System.Collections.Generic;

using System.Runtime.InteropServices;
using vJoyInterfaceWrap;

namespace vSlide
{
    public partial class MainForm : Form
    {
        #region Fields

        // Keys
        private Keys nextLevelKey = Keys.LShiftKey;
        public Keys NextLevelKey
        {
            get { return nextLevelKey; }
            set
            {
                // Prevents the key from getting set to None
                if(value == Keys.None)
                {
                    Log("Tried to set the 'NextLevelKey' to None, returning...");
                    return;
                }

                nextLevelKey = value;
                nextLevelKeyState = KeyState.Up;
                nextLevelKeyCurrDownTime = 0;
            }
        }
        private Keys controlModNextLevelKey = Keys.None;
        public Keys ControlModNextLevelKey
        {
            get { return controlModNextLevelKey; }
            set
            {
                controlModNextLevelKey = value;
                nextLevelKeyState = KeyState.Up;
                nextLevelKeyCurrDownTime = 0;
            }
        }
        private Keys shiftModNextLevelKey = Keys.None;
        public Keys ShiftModNextLevelKey
        {
            get { return shiftModNextLevelKey; }
            set
            {
                shiftModNextLevelKey = value;
                nextLevelKeyState = KeyState.Up;
                nextLevelKeyCurrDownTime = 0;
            }
        }
        private Keys altModNextLevelKey = Keys.None;
        public Keys AltModNextLevelKey
        {
            get { return altModNextLevelKey; }
            set
            {
                altModNextLevelKey = value;
                nextLevelKeyState = KeyState.Up;
                nextLevelKeyCurrDownTime = 0;
            }
        }
        private KeyState nextLevelKeyState = KeyState.Up;
        private int nextLevelKeyCurrDownTime = 0;

        private Keys prevLevelKey = Keys.LControlKey;
        public Keys PrevLevelKey
        {
            get { return prevLevelKey; }
            set
            {
                // Prevents the key from getting set to None
                if (value == Keys.None)
                {
                    Log("Tried to set the 'PrevLevelKey' to None, returning...");
                    return;
                }

                prevLevelKey = value;
                prevLevelKeyState = KeyState.Up;
                prevLevelKeyCurrDownTime = 0;
            }
        }
        private Keys controlModPrevLevelKey = Keys.None;
        public Keys ControlModPrevLevelKey
        {
            get { return controlModPrevLevelKey; }
            set
            {
                controlModPrevLevelKey = value;
                prevLevelKeyState = KeyState.Up;
                prevLevelKeyCurrDownTime = 0;
            }
        }
        private Keys shiftModPrevLevelKey = Keys.None;
        public Keys ShiftModPrevLevelKey
        {
            get { return shiftModPrevLevelKey; }
            set
            {
                shiftModPrevLevelKey = value;
                prevLevelKeyState = KeyState.Up;
                prevLevelKeyCurrDownTime = 0;
            }
        }
        private Keys altModPrevLevelKey = Keys.None;
        public Keys AltModPrevLevelKey
        {
            get { return altModPrevLevelKey; }
            set
            {
                altModPrevLevelKey = value;
                prevLevelKeyState = KeyState.Up;
                prevLevelKeyCurrDownTime = 0;
            }
        }
        private KeyState prevLevelKeyState = KeyState.Up;
        private int prevLevelKeyCurrDownTime = 0;

        private Keys incrSliderKey = Keys.E;
        public Keys IncrSliderKey
        {
            get { return incrSliderKey; }
            set
            {
                // Prevents the key from getting set to None
                if (value == Keys.None)
                {
                    Log("Tried to set the 'IncrSliderKey' to None, returning...");
                    return;
                }

                incrSliderKey = value;
                incrSliderKeyState = KeyState.Up;
                incrSliderKeyCurrDownTime = 0;
            }
        }
        private Keys controlModIncrSliderKey = Keys.None;
        public Keys ControlModIncrSliderKey
        {
            get { return controlModIncrSliderKey; }
            set
            {
                controlModIncrSliderKey = value;
                incrSliderKeyState = KeyState.Up;
                incrSliderKeyCurrDownTime = 0;
            }
        }
        private Keys shiftModIncrSliderKey = Keys.None;
        public Keys ShiftModIncrSliderKey
        {
            get { return shiftModIncrSliderKey; }
            set
            {
                shiftModIncrSliderKey = value;
                incrSliderKeyState = KeyState.Up;
                incrSliderKeyCurrDownTime = 0;
            }
        }
        private Keys altModIncrSliderKey = Keys.None;
        public Keys AltModIncrSliderKey
        {
            get { return altModIncrSliderKey; }
            set
            {
                altModIncrSliderKey = value;
                incrSliderKeyState = KeyState.Up;
                incrSliderKeyCurrDownTime = 0;
            }
        }
        private KeyState incrSliderKeyState = KeyState.Up;
        private int incrSliderKeyCurrDownTime = 0;

        private Keys decrSliderKey = Keys.Q;
        public Keys DecrSliderKey
        {
            get { return decrSliderKey; }
            set
            {
                // Prevents the key from getting set to None
                if (value == Keys.None)
                {
                    Log("Tried to set the 'DecrSliderKey' to None, returning...");
                    return;
                }

                decrSliderKey = value;
                decrSliderKeyState = KeyState.Up;
                decrSliderKeyCurrDownTime = 0;
            }
        }
        private Keys controlModDecrSliderKey = Keys.None;
        public Keys ControlModDecrSliderKey
        {
            get { return controlModDecrSliderKey; }
            set
            {
                controlModDecrSliderKey = value;
                decrSliderKeyState = KeyState.Up;
                decrSliderKeyCurrDownTime = 0;
            }
        }
        private Keys shiftModDecrSliderKey = Keys.None;
        public Keys ShiftModDecrSliderKey
        {
            get { return shiftModDecrSliderKey; }
            set
            {
                shiftModDecrSliderKey = value;
                decrSliderKeyState = KeyState.Up;
                decrSliderKeyCurrDownTime = 0;
            }
        }
        private Keys altModDecrSliderKey = Keys.None;
        public Keys AltModDecrSliderKey
        {
            get { return altModDecrSliderKey; }
            set
            {
                altModDecrSliderKey = value;
                decrSliderKeyState = KeyState.Up;
                decrSliderKeyCurrDownTime = 0;
            }
        }
        private KeyState decrSliderKeyState = KeyState.Up;
        private int decrSliderKeyCurrDownTime = 0;

        // Variables related to the level keys
        bool isUsingLevelKeys;
        public bool IsUsingLevelKeys
        {
            get { return isUsingLevelKeys; }
            set
            {
                isUsingLevelKeys = value;
                useLevelKeysLabel.Text = value.ToString();
            }
        }
        KeyHoldDownMode holdDownModeLevel;
        public KeyHoldDownMode HoldDownModeLevel
        {
            set
            {
                holdDownModeLevel = value;
                holdModeLevelLabel.Text = value.ToString();
            }
        }
        int holdTresholdLevel;
        public int HoldTresholdLevel
        {
            get { return holdTresholdLevel; }
            set
            {
                value = Math.Max(value, 0);
                holdTresholdLevel = value;
                holdTresholdLevelLabel.Text = value + " ms";
            }
        }
        int holdTickIntervalLevel;
        public int HoldTickIntervalLevel
        {
            get { return holdTickIntervalLevel; }
            set
            {
                value = Math.Max(value, 0);
                holdTickIntervalLevel = value;
                tickIntervalLevelLabel.Text = value + " ms";
            }
        }

        // Variables related to the slider keys
        bool isUsingSliderKeys;
        public bool IsUsingSliderKeys
        {
            get { return isUsingSliderKeys; }
            set
            {
                isUsingSliderKeys = value;
                useSliderKeysLabel.Text = value.ToString();
            }
        }
        KeyHoldDownMode holdDownModeSlider;
        public KeyHoldDownMode HoldDownModeSlider
        {
            set
            {
                holdDownModeSlider = value;
                holdModeSliderLabel.Text = value.ToString();
            }
        }
        int holdTresholdSlider;
        public int HoldTresholdSlider
        {
            set
            {
                value = Math.Max(value, 0);
                holdTresholdSlider = value;
                holdTresholdSliderLabel.Text = value + " ms";
            }
        }
        int holdTickIntervalSlider;
        public int HoldTickIntervalSlider
        {
            set
            {
                value = Math.Max(value, 0);
                holdTickIntervalSlider = value;
                tickIntervalSliderLabel.Text = value + " ms";
            }
        }
        int holdSliderDeltaPerTick;
        public int HoldSliderDeltaPerTick
        {
            set
            {
                value = Math.Max(value, 0);
                holdSliderDeltaPerTick = value;
                sliderDeltaSliderLabel.Text = value.ToString();
            }
        }

        // Joystick variables
        public vJoy vJoyDriver;
        private uint currJoystickId = 0;
        public uint CurrJoystickId
        {
            get { return currJoystickId; }
            set
            {
                currJoystickId = value;

                // Updates the info label
                usedVJoyDeviceLabel.Text = currJoystickId.ToString();
            }
        }

        // Slider variables
        private int maxSliderValue;
        public int MaxSliderValue
        {
            get { return maxSliderValue; }
            set
            {
                maxSliderValue = Math.Max(1, value);

                // Sets Labels in the form
                maxSliderValueLabel.Text = maxSliderValue.ToString();
            }
        }
        private int currSliderValue;
        private int CurrSliderValue
        {
            get { return currSliderValue; }
            set
            {
                // Clamps the value between 0 and 'maxSliderValue'
                value = Math.Max(value, 0);
                value = Math.Min(value, maxSliderValue);
                currSliderValue = value;

                // Updates the labels in the form
                currSliderValueLabel.Text = currSliderValue.ToString();
                currSliderValueRelLabel.Text = String.Format("{0:F2}", (currSliderValue * 100m) / maxSliderValue) + "%";

                // Updates the sliderTrackBar
                sliderTrackBar.Value = (int)(((float)currSliderValue / maxSliderValue) * 100);
            }
        }

        // Ping pong variables
        private int pingPongStepValue = 300;
        private enum PingPongState { Disabled, Increasing, Decreasing };
        private PingPongState currPingPongState = PingPongState.Disabled;

        // Info text
        string noVJoyDeviceInfoText = "A vJoy Device has to be acquired in order to feed the driver!";
        string settingUpInfoText = "The programm isn't finished with setting up.";
        string setupFailedInfoText = "Startup procedure failed, can't continue. You can close this programm.";
        string vJoyDisabledInfoText = "Failed Getting vJoy attributes: vJoy driver not enabled or not installed, returning...";
        string driverAndDllVersMatchInfoText = "Version of the vJoy driver matches the DLL version: '{0:X}'";
        string driverAndDllVersDontMatchInfoText = "Version of driver '{0:X}' does NOT match DLL version '{1:X}', returning...";

        // Feeder state
        private FeederState currState;
        private FeederState CurrState
        {
            get { return currState; }
            set
            {
                currState = value;
                currFeederStateLabel.Text = value.ToString();

                if(currState == FeederState.SettingUp)
                {
                    toggleFeedingButton.Enabled = false;
                    otherFormsMenuStrip.Enabled = false;
                    canNotFeedInfoLabel.Text = settingUpInfoText;
                    canNotFeedInfoLabel.Visible = true;
                }
                else if (currState == FeederState.NoVJoyDevice)
                {
                    toggleFeedingButton.Enabled = false;
                    canNotFeedInfoLabel.Text = noVJoyDeviceInfoText;
                    canNotFeedInfoLabel.Visible = true;
                }
                else if (currState == FeederState.ReadyToFeed || currState == FeederState.Feeding)
                {
                    toggleFeedingButton.Enabled = true;
                    canNotFeedInfoLabel.Text = "";
                    canNotFeedInfoLabel.Visible = false;
                }
            }
        }
        
        // Forms
        SliderLevelsForm sliderLevelsForm;
        SettingsForm settingsForm;
        AboutForm aboutForm;
        InstructionsForm instructionsForm;

        // DLL library used to manage hotkeys
        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(Keys vKey);

        // Other
        private bool inDebugMode = true;
        private bool InDebugMode
        {
            get { return InDebugMode; }
            set
            {
                inDebugMode = value;
                debugInfoGroupBox.Visible = value;
            }
        }
        #endregion

        public delegate void JoystickChangeHandler(uint joystickId, int maxSliderValue);
        public event JoystickChangeHandler NewJoystickAcquired;

        public MainForm()
        {
            InitializeComponent();

            Log("Thank you for using vSlide");
            Log("Feel free to contact me if you are stuck or need help.");
            Log("");

            // Create a vJoy instance
            vJoyDriver = new vJoy();
            VjdStat status;
            CurrState = FeederState.SettingUp;

            //Sets 'MaxSliderValue' to its default value, so that mapping levels can be adjusted even if no jostick device can be acquired
            MaxSliderValue = 32767;
            
            // Checks if vJoy is enabled
            if (vJoyDriver.vJoyEnabled())
            {
                Log("vJoy - Vendor: " + vJoyDriver.GetvJoyManufacturerString());
                Log("vJoy - Product: " + vJoyDriver.GetvJoyProductString());
                Log("vJoy - Version Number: " + vJoyDriver.GetvJoySerialNumberString());
                vJoyDriverFoundLabel.Text = "Yes";
            }
            else
            {
                Log(vJoyDisabledInfoText);
                vJoyDriverFoundLabel.Text = "No";
                Log(setupFailedInfoText);
                return;
            }

            UInt32 DllVer = 0, DrvVer = 0;
            // Tests if the dll version matches the driver version
            if (vJoyDriver.DriverMatch(ref DllVer, ref DrvVer))
            {
                Log(String.Format(driverAndDllVersMatchInfoText, DllVer));
            }
            else
            {
                Log(String.Format(driverAndDllVersDontMatchInfoText, DrvVer, DllVer));
                Log(setupFailedInfoText);
                return;
            }

            // Updates the dll and driver version info labels
            vJoyDriverVersionLabel.Text = String.Format("{0:X}", DrvVer);
            vJoyDllVersionLabel.Text = String.Format("{0:X}", DllVer);
            
            // Stores all joysticks that are free or busy
            List<uint> availableJoystickIds = new List<uint>();

            Log("");
            Log("Searching for vJoy devices...");
            // Loops through all possible joystick id's and adds existing ones to the 'availableJoystickIds' list
            for (uint id = 0; id <= 16; id++)
            {
                // Get the state of the device
                status = vJoyDriver.GetVJDStatus(id);
                
                if (status == VjdStat.VJD_STAT_UNKN)
                {
                    Log("Ignoring device '" + id + "'. It's status is unknown");
                }
                else if (status == VjdStat.VJD_STAT_MISS)
                {
                    Log("Ignoring device '" + id + "'. It's not installed or disabled");
                }
                else if (!vJoyDriver.GetVJDAxisExist(id, HID_USAGES.HID_USAGE_SL0))
                {
                    Log("Ignoring device  '" + id + "'. It has no slider axis.");
                }
                else if(status == VjdStat.VJD_STAT_OWN)
                {
                    // Relinquishs the device
                    Log("Device '" + id + "' is already acquired! relinquishing it...");
                    vJoyDriver.RelinquishVJD(id);
                    status = vJoyDriver.GetVJDStatus(id);

                    // Adds the device to the list if its now free
                    if(status == VjdStat.VJD_STAT_FREE)
                    {
                        Log("Adding device '" + id + "' with status '" + status + "' to the device list.");
                        availableJoystickIds.Add(id);
                    }
                    else
                    {
                        Log("Device '" + id + "' couldn't be relinquished, ignoring it...");
                    }
                }
                else if (status == VjdStat.VJD_STAT_FREE || status == VjdStat.VJD_STAT_BUSY)
                {
                    Log("Adding device '" + id + "' with status '" + status + "' to the device list.");
                    availableJoystickIds.Add(id);
                }
            }
            
            // Iterates through the list of free and busy devices and acquires the first one that is free
            Log("");
            Log("Acquiring free device...");
            foreach (uint id in availableJoystickIds)
            {
                if (vJoyDriver.GetVJDStatus(id) == VjdStat.VJD_STAT_FREE && AcquireNewJoystick(id))
                {
                    break;
                }
            }

            if (vJoyDriver.GetVJDStatus(CurrJoystickId) != VjdStat.VJD_STAT_OWN)
            {
                Log("Couldn't acquire a device: There was no free vJoy device!");
            }

            // Checks if the key variables are set up correctly
            CheckKeyBinds();
            
            Log("");
            Log("Creating mapping-theme-form...");
            sliderLevelsForm = new SliderLevelsForm(this, 7);

            Log("");
            Log("Creating settings-form...");
            settingsForm = new SettingsForm(this, availableJoystickIds);

            Log("");
            Log("Creating about-form...");
            aboutForm = new AboutForm();

            Log("");
            Log("Creating instuctions-form...");
            instructionsForm = new InstructionsForm();

            // Loads the settings
            Log("");
            settingsForm.LoadSettings();

            // Loads the slider levels
            Log("");
            sliderLevelsForm.LoadSliderLevels();

            // Enables the other forms menu strip
            otherFormsMenuStrip.Enabled = true;

            // Debugs aditional information
            Log("");
            Log("The Next-Level-Key is bound to '" + nextLevelKey.ToString() + "'");
            Log("The Previous-Level-Key is bound to '" + prevLevelKey.ToString() + "'");
            Log("The Increase-Slider-Key is bound to '" + incrSliderKey.ToString() + "'");
            Log("The Decrease-Slider-Key is bound to '" + decrSliderKey.ToString() + "'");
            Log("");

            // Checks if a device was aquired
            if (vJoyDriver.GetVJDStatus(CurrJoystickId) == VjdStat.VJD_STAT_OWN)
            {
                CurrState = FeederState.ReadyToFeed;
                Log("Everything is setup you can now start by pressing the 'Start feeding' button.");
                Log("Click the 'Instructions' button at the top if you need help!");
            }
            else
            {
                CurrState = FeederState.NoVJoyDevice;
                Log("The setup finished but no vJoy device is aquired!");
                Log("Open the 'Configure vJoy devices' app to make sure that there is a free device with a slider axis. Restart the feeder afterwards.");
            }

            InDebugMode = debugModeCheckBox.Checked;
        }

        #region Methods

        /// <summary>
        /// Acquires a new joystick-driver
        /// </summary>
        /// <param name="newJoystickId"> The id of the device that should be acquired </param>
        /// <returns> Returns true if the device was acquired, otherwise returns false </returns>
        public bool AcquireNewJoystick(uint newJoystickId)
        {
            // Stops feeding
            if(CurrState == FeederState.Feeding)
            {
                StopFeeding();
            }
            
            Log("Acquiring device '" + newJoystickId + "'...");

            // Checks if there still is an 'old' joystick-driver that is currently acquired by the feeder
            if (vJoyDriver.GetVJDStatus(CurrJoystickId) == VjdStat.VJD_STAT_OWN)
            {
                // Relinquish's the old joystick-driver
                Log("The feeder still owns the joystick '" + CurrJoystickId + "'  relinquishing it...");
                vJoyDriver.RelinquishVJD(CurrJoystickId);
            }

            // Checks if the new device is already acquired
            if (vJoyDriver.GetVJDStatus(newJoystickId) == VjdStat.VJD_STAT_OWN)
            {
                // Relinquish's the new joystick-driver
                Log("Device '" + newJoystickId + "' is already acquired! relinquishing it...");
                vJoyDriver.RelinquishVJD(newJoystickId);
            }

            // Checks if the new driver is free
            if (vJoyDriver.GetVJDStatus(newJoystickId) != VjdStat.VJD_STAT_FREE)
            {
                Log("Device '" + newJoystickId + "' wasn't free, couldn't acquire it, returning...");
                return false;
            }

            // Checks if the new driver has a slider axis
            if (!vJoyDriver.GetVJDAxisExist(newJoystickId, HID_USAGES.HID_USAGE_SL0))
            {
                Log("Device '" + newJoystickId + "' has no slider axis, returning...");
                return false;
            }

            // Acquires the device
            if (vJoyDriver.AcquireVJD(newJoystickId))
            {
                Log("Acquired vJoy device with id '" + newJoystickId + "'");
                CurrJoystickId = newJoystickId;
            }
            else
            {
                Log("Failed to acquire vJoy device with id '" + newJoystickId + "', returning...");
                return false;
            }

            // Reset the acquired device to default values
            vJoyDriver.ResetVJD(currJoystickId);

            // Sets the 'maxSliderValue' and 'CurrSliderValue' variables
            long newMaxValue = MaxSliderValue;
            vJoyDriver.GetVJDAxisMax(currJoystickId, HID_USAGES.HID_USAGE_SL0, ref newMaxValue);

            MaxSliderValue = (int)newMaxValue;
            CurrSliderValue = 0;

            // Sets all axis of the new driver to 50%
            if(vJoyDriver.GetVJDAxisExist(CurrJoystickId, HID_USAGES.HID_USAGE_X))
                vJoyDriver.SetAxis((maxSliderValue / 2), currJoystickId, HID_USAGES.HID_USAGE_X);
            if (vJoyDriver.GetVJDAxisExist(CurrJoystickId, HID_USAGES.HID_USAGE_Y))
                vJoyDriver.SetAxis((maxSliderValue / 2), currJoystickId, HID_USAGES.HID_USAGE_Y);
            if (vJoyDriver.GetVJDAxisExist(CurrJoystickId, HID_USAGES.HID_USAGE_Z))
                vJoyDriver.SetAxis((maxSliderValue / 2), currJoystickId, HID_USAGES.HID_USAGE_Z);
            if (vJoyDriver.GetVJDAxisExist(CurrJoystickId, HID_USAGES.HID_USAGE_RX))
                vJoyDriver.SetAxis((maxSliderValue / 2), currJoystickId, HID_USAGES.HID_USAGE_RX);
            if (vJoyDriver.GetVJDAxisExist(CurrJoystickId, HID_USAGES.HID_USAGE_RY))
                vJoyDriver.SetAxis((maxSliderValue / 2), currJoystickId, HID_USAGES.HID_USAGE_RY);
            if (vJoyDriver.GetVJDAxisExist(CurrJoystickId, HID_USAGES.HID_USAGE_RZ))
                vJoyDriver.SetAxis((maxSliderValue / 2), currJoystickId, HID_USAGES.HID_USAGE_RZ);
            if (vJoyDriver.GetVJDAxisExist(CurrJoystickId, HID_USAGES.HID_USAGE_SL0))
                vJoyDriver.SetAxis((maxSliderValue / 2), currJoystickId, HID_USAGES.HID_USAGE_SL0);
            if (vJoyDriver.GetVJDAxisExist(CurrJoystickId, HID_USAGES.HID_USAGE_SL1))
                vJoyDriver.SetAxis((maxSliderValue / 2), currJoystickId, HID_USAGES.HID_USAGE_SL1);

            // Updates the currState
            if (CurrState == FeederState.NoVJoyDevice)
            {
                CurrState = FeederState.ReadyToFeed;
            }

            // Invokes the 'NewJoystickAcquired' event
            if (NewJoystickAcquired != null)
            {
                NewJoystickAcquired(CurrJoystickId, MaxSliderValue);
            }
            
            return true;
        }

        /// <summary>
        /// Checks if the current key bounds are valid
        /// </summary>
        private void CheckKeyBinds()
        {
            // Checks if the incrSliderKey value is valid
            if (!Enum.IsDefined(typeof(Keys), nextLevelKey))
            {
                Log("The 'nextLevelKey' has the invalid value '" + nextLevelKey + "' this value does not represent a key, returning...");
                return;
            }
            // Checks if the decrSliderKey value is valid
            if (!Enum.IsDefined(typeof(Keys), prevLevelKey))
            {
                Log("The 'prevLevelKey' has the invalid value '" + prevLevelKey + "' this value does not represent a key, returning...");
                return;
            }

            // Checks if the nextLevelKey and prevLevelKey are bound to the same key
            if (incrSliderKey == decrSliderKey)
            {
                Log("The 'nextLevelKey' and 'prevLevelKey' are bound to the same key '" + nextLevelKey + "', returning...");
                return;
            }

            // Checks if the incrSliderKey value is valid
            if (!Enum.IsDefined(typeof(Keys), incrSliderKey))
            {
                Log("The 'incrSliderKey' has the invalid value '" + incrSliderKey + "' this value does not represent a key, returning...");
                return;
            }
            // Checks if the decrSliderKey value is valid
            if (!Enum.IsDefined(typeof(Keys), decrSliderKey))
            {
                Log("The 'decrSliderKey' has the invalid value '" + decrSliderKey + "' this value does not represent a key, returning...");
                return;
            }

            // Checks if the incrSliderKey and decrSliderKey are the same
            if (incrSliderKey == decrSliderKey)
            {
                Log("The 'incrSliderKey' and 'decrSliderKey' are bound to the same key '" + Enum.GetName(typeof(Keys), incrSliderKey) + "', returning...");
                return;
            }
        }

        /// <summary>
        /// Starts feeding the acquired joystick driver if the feeder is in the 'ReadyToFeed' state
        /// </summary>
        private void StartFeeding()
        {
            // Returns if the feeder isn't ready to feed
            if (CurrState != FeederState.ReadyToFeed) return;

            CurrState = FeederState.Feeding;
            nextLevelKeyState = KeyState.Up;
            prevLevelKeyState = KeyState.Up;
            incrSliderKeyState = KeyState.Up;
            decrSliderKeyState = KeyState.Up;
            nextLevelKeyCurrDownTime = 0;
            prevLevelKeyCurrDownTime = 0;
            incrSliderKeyCurrDownTime = 0;
            decrSliderKeyCurrDownTime = 0;

            toggleFeedingButton.Text = "Stop feeding";
            sliderTrackBar.Enabled = true;
            pingPongCheckBox.Enabled = true;
            inputCheckTimer.Enabled = true;
            inputCheckTimer.Start();
        }

        /// <summary>
        /// Stops feeding the acquired joystick driver if the feeder is in the 'Feeding' state
        /// </summary>
        private void StopFeeding()
        {
            // Returns if the feeder isn't feeding
            if (CurrState != FeederState.Feeding) return;

            CurrState = FeederState.ReadyToFeed;
            nextLevelKeyState = KeyState.Up;
            prevLevelKeyState = KeyState.Up;
            incrSliderKeyState = KeyState.Up;
            decrSliderKeyState = KeyState.Up;
            nextLevelKeyCurrDownTime = 0;
            prevLevelKeyCurrDownTime = 0;
            incrSliderKeyCurrDownTime = 0;
            decrSliderKeyCurrDownTime = 0;

            toggleFeedingButton.Text = "Start feeding";
            sliderTrackBar.Enabled = false;
            pingPongCheckBox.Checked = false;
            pingPongCheckBox.Enabled = false;
            inputCheckTimer.Stop();
            inputCheckTimer.Enabled = false;
        }

        /// <summary>
        /// Updates the slider axis in the currently acquired joystick driver
        /// </summary>
        private void UpdateSliderInVJoyDriver()
        {
            if (currSliderValue > maxSliderValue)
                currSliderValue = (int)maxSliderValue;
            else if (currSliderValue < 0)
                currSliderValue = 0;

            vJoyDriver.SetAxis(currSliderValue, currJoystickId, HID_USAGES.HID_USAGE_SL0);
        }

        /// <summary>
        /// Appends a string in the debug textBox and writes it to the console aswell
        /// </summary>
        /// <param name="message"></param>
        public void Log(string message)
        {
            Console.WriteLine(message);
            
            if(inDebugMode)
            {
                logTextBox.AppendText(message + "\n");
            }
        }
        
        private void LogInstructions()
        {
            Log("");
            Log("");
            Log("                                                                              Instructions:");
            Log("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Log("Press the button in the lower left corner to start the feeder.");
            Log("The slider-bar below this textbox represents the slider value of the virtual vJoy device.");
            Log("");
            Log("- Key Binds:");
            Log("You can increase the slider's value to the next slider-level with the 'left shift' key (default).");
            Log("The 'left control' key (default) decreases the slider's value to the previous slider-level.");
            Log("");
            Log("You can alter the sliders value by small amounts aswell.");
            Log("Use the 'q' key (default) to decrease and the 'e' (default) key to increase.");
            Log("");
            Log("Key binds can be changed in the lower left corner in the settings menu.");
            Log("");
            Log("- Key Setup:");
            Log("You think 4 keys are too many?");
            Log("Customize the behaviour of the feeder in the 'Key Setup'-category in the settings!");
            Log("You can mess with those as much as you want.");
            Log("");
            Log("Checking 'Use Level Keys only' and 'Use the hold down logic for the slider system', for example, allows");
            Log("you to swith to another slider-level and alter the slider by small amounts aswell.");
            Log("A fast tab on the key will change the slider-level while holding the key down will alter the slider");
            Log("value by a samll amount.");
            Log("");
            Log("- Ping Pong Lerping");
            Log("Lerps the slider value from zero to max endlessly.");
            Log("Use this to bind the slider axis to the analogue collective in Amra!");
            Log("");
            Log("- vJoy Device:");
            Log("You can swap to another vJoy device in the lower left corner in the settings menu.");
            Log("");
            Log("Feel free to contact me if you are stuck or need help.");
            Log("Thank you for using vSlide!");
            Log("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Log("");
            
        }

        public string VjdStatToString(VjdStat status)
        {
            switch (status)
            {
                case VjdStat.VJD_STAT_FREE:
                    return "Free";

                case VjdStat.VJD_STAT_OWN:
                    return "Acquired";

                case VjdStat.VJD_STAT_BUSY:
                    return "Busy";

                case VjdStat.VJD_STAT_MISS:
                    return "Not Installed";

                default:
                    return "Unknown";
            }
        }

        #endregion

        #region Event Methods

        private void MainForm_Shown(object sender, EventArgs e)
        {
            // Scrolls the logTextBox to the bottom, since it somehow isn't scrolled all
            // the way down after setting up
            logTextBox.ScrollToCaret();
        }

        private void toggleFeedingButton_Click(object sender, EventArgs e)
        {
            if(CurrState == FeederState.ReadyToFeed) StartFeeding();

            else if (CurrState == FeederState.Feeding) StopFeeding();
        }
        
        private void pingPongCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(pingPongCheckBox.Checked && CurrState == FeederState.Feeding)
            {
                Log("Starting ping pong timer...");
                currPingPongState = PingPongState.Decreasing;
                pingPongTimer.Start();
            }
            else if (currPingPongState != PingPongState.Disabled)
            {
                Log("Stopping ping pong timer...");
                currPingPongState = PingPongState.Disabled;
                pingPongTimer.Stop();
            }
        }

        private void pingPongTimer_Tick(object sender, EventArgs e)
        {
            // Returns if the programm is currently not feeding
            if (CurrState != FeederState.Feeding) return;
            
            // Checks if the slider reached its max or 0 value, and changes the currPingPongState
            if (CurrSliderValue >= maxSliderValue)
                currPingPongState = PingPongState.Decreasing;
            else if (CurrSliderValue <= 0)
                currPingPongState = PingPongState.Increasing;

            // Increases the slider
            if (currPingPongState == PingPongState.Increasing)
            {
                CurrSliderValue += pingPongStepValue;
                UpdateSliderInVJoyDriver();
            }
            // Decreases the slider
            else if (currPingPongState == PingPongState.Decreasing)
            {
                CurrSliderValue -= pingPongStepValue;
                UpdateSliderInVJoyDriver();
            }
        }

        private void inputCheckTimer_Tick(object sender, EventArgs e)
        {
            // Returns if the programm is currently not feeding
            if(CurrState != FeederState.Feeding) return;

            #region Level Keys
            if (isUsingLevelKeys)
            {
                KeyState newNextLevelKeyState = KeyState.Down;
                newNextLevelKeyState = GetAsyncKeyState(nextLevelKey) == 0 ? KeyState.Up : newNextLevelKeyState;
                newNextLevelKeyState = controlModNextLevelKey != Keys.None && GetAsyncKeyState(controlModNextLevelKey) == 0 ? KeyState.Up : newNextLevelKeyState;
                newNextLevelKeyState = shiftModNextLevelKey != Keys.None && GetAsyncKeyState(shiftModNextLevelKey) == 0 ? KeyState.Up : newNextLevelKeyState;
                newNextLevelKeyState = altModNextLevelKey != Keys.None && GetAsyncKeyState(altModNextLevelKey) == 0 ? KeyState.Up : newNextLevelKeyState;

                KeyState newPrevLevelKeyState = KeyState.Down;
                newPrevLevelKeyState = GetAsyncKeyState(prevLevelKey) == 0 ? KeyState.Up : newPrevLevelKeyState;
                newPrevLevelKeyState = controlModPrevLevelKey != Keys.None && GetAsyncKeyState(controlModPrevLevelKey) == 0 ? KeyState.Up : newPrevLevelKeyState;
                newPrevLevelKeyState = shiftModPrevLevelKey != Keys.None && GetAsyncKeyState(shiftModPrevLevelKey) == 0 ? KeyState.Up : newPrevLevelKeyState;
                newPrevLevelKeyState = altModPrevLevelKey != Keys.None && GetAsyncKeyState(altModPrevLevelKey) == 0 ? KeyState.Up : newPrevLevelKeyState;

                // Checks if the 'nextLevelKey' was 'Up' when last checked and if its now 'Down'
                if (nextLevelKeyState == KeyState.Up && newNextLevelKeyState == KeyState.Down)
                {
                    Log("Next-Level-Key '" + nextLevelKey.ToString() + "' is now down...");

                    // Increases the currSliderValue to the next Level when the key is down only when
                    // the keyHoldDownMode isn't in slider mode
                    if (holdDownModeLevel != KeyHoldDownMode.Slider)
                    {
                        CurrSliderValue = sliderLevelsForm.GetSliderValueOfTheNextLevel(CurrSliderValue);
                        UpdateSliderInVJoyDriver();
                    }
                    nextLevelKeyState = KeyState.Down;
                    nextLevelKeyCurrDownTime = 0;
                }

                // Checks if the 'nextLevelKey' was 'Down' or 'HeldDown' when last checked and if its now up
                if ((nextLevelKeyState == KeyState.Down || nextLevelKeyState == KeyState.HeldDown) && newNextLevelKeyState == KeyState.Up)
                {
                    Log("Next-Level-Key '" + nextLevelKey.ToString() + "' is now up...");

                    // Increases the currSliderValue to the next Level when the key is up only when
                    // the keyHoldDownMode is in slider mode
                    if (holdDownModeLevel == KeyHoldDownMode.Slider && nextLevelKeyState == KeyState.Down)
                    {
                        CurrSliderValue = sliderLevelsForm.GetSliderValueOfTheNextLevel(CurrSliderValue);
                        UpdateSliderInVJoyDriver();
                    }
                    nextLevelKeyState = KeyState.Up;
                    nextLevelKeyCurrDownTime = 0;
                }

                // Checks if the 'prevLevelKey' was 'Up' when last checked and if its now 'Down'
                if (prevLevelKeyState == KeyState.Up && newPrevLevelKeyState == KeyState.Down)
                {
                    Log("Previous-Level-Key '" + prevLevelKey.ToString() + "' is now down...");
                    
                    // Decreases the currSliderValue to the previous Level when the key is down only when
                    // the keyHoldDownMode isn't in slider mode
                    if (holdDownModeLevel != KeyHoldDownMode.Slider)
                    {
                        CurrSliderValue = sliderLevelsForm.GetSliderValueOfThePreviousLevel(CurrSliderValue);
                        UpdateSliderInVJoyDriver();
                    }
                    prevLevelKeyState = KeyState.Down;
                    prevLevelKeyCurrDownTime = 0;
                }

                // Checks if the 'prevLevelKey' was 'Down' or 'HeldDown' when last checked and if its now up
                if ((prevLevelKeyState == KeyState.Down || prevLevelKeyState == KeyState.HeldDown) && newPrevLevelKeyState == KeyState.Up)
                {
                    Log("Previous-Level-Key '" + prevLevelKey.ToString() + "' is now up...");

                    // Decreases the currSliderValue to the previous Level when the key is up only when
                    // the keyHoldDownMode is in slider mode
                    if (holdDownModeLevel == KeyHoldDownMode.Slider && prevLevelKeyState == KeyState.Down)
                    {
                        CurrSliderValue = sliderLevelsForm.GetSliderValueOfThePreviousLevel(CurrSliderValue);
                        UpdateSliderInVJoyDriver();
                    }
                    prevLevelKeyState = KeyState.Up;
                    prevLevelKeyCurrDownTime = 0;
                }
                
                // Rund the 'hold down logic' if the hold down mode isn't 'None' 
                if (holdDownModeLevel != KeyHoldDownMode.None)
                {
                    // Increases the current down time of the key if its state is 'Down' or 'HeldDown'
                    if (nextLevelKeyState == KeyState.Down || nextLevelKeyState == KeyState.HeldDown)
                    {
                        nextLevelKeyCurrDownTime += inputCheckTimer.Interval;
                    }

                    // Sets the keyState to 'HeldDown' if its currently 'Down' and the currDownTime reached the holdTreshold
                    if (nextLevelKeyState == KeyState.Down && nextLevelKeyCurrDownTime >= holdTresholdLevel)
                    {
                        nextLevelKeyState = KeyState.HeldDown;
                    }

                    // Increases the slider if its state is 'HeldDown' and the currDownTime reached the holdTickInterval
                    if (nextLevelKeyState == KeyState.HeldDown && nextLevelKeyCurrDownTime >= holdTickIntervalLevel)
                    {
                        nextLevelKeyCurrDownTime = 0;

                        if (holdDownModeLevel == KeyHoldDownMode.Level)
                        {
                            CurrSliderValue = sliderLevelsForm.GetSliderValueOfTheNextLevel(CurrSliderValue);
                        }
                        else if (holdDownModeLevel == KeyHoldDownMode.Slider)
                        {
                            CurrSliderValue += holdSliderDeltaPerTick;
                        }

                        UpdateSliderInVJoyDriver();
                    }

                    // Increases the current down time of the key if its state is 'Down' or 'HeldDown'
                    if (prevLevelKeyState == KeyState.Down || prevLevelKeyState == KeyState.HeldDown)
                    {
                        prevLevelKeyCurrDownTime += inputCheckTimer.Interval;
                    }

                    // Sets the keyState to 'HeldDown' if its currently 'Down' and the currDownTime reached the holdTreshold
                    if (prevLevelKeyState == KeyState.Down && prevLevelKeyCurrDownTime >= holdTresholdLevel)
                    {
                        prevLevelKeyState = KeyState.HeldDown;
                    }

                    // Decreases the slider if its state is 'HeldDown' and the currDownTime reached the holdTickInterval
                    if (prevLevelKeyState == KeyState.HeldDown && prevLevelKeyCurrDownTime >= holdTickIntervalLevel)
                    {
                        prevLevelKeyCurrDownTime = 0;

                        if (holdDownModeLevel == KeyHoldDownMode.Level)
                        {
                            CurrSliderValue = sliderLevelsForm.GetSliderValueOfThePreviousLevel(CurrSliderValue);
                        }
                        else if (holdDownModeLevel == KeyHoldDownMode.Slider)
                        {
                            CurrSliderValue -= holdSliderDeltaPerTick;
                        }
                        UpdateSliderInVJoyDriver();
                    }
                }

            }
            #endregion

            #region Slider Keys
            if (isUsingSliderKeys)
            {
                KeyState newIncrSliderKeyState = KeyState.Down;
                newIncrSliderKeyState = GetAsyncKeyState(incrSliderKey) == 0 ? KeyState.Up : newIncrSliderKeyState;
                newIncrSliderKeyState = controlModIncrSliderKey != Keys.None && GetAsyncKeyState(controlModIncrSliderKey) == 0 ? KeyState.Up : newIncrSliderKeyState;
                newIncrSliderKeyState = shiftModIncrSliderKey != Keys.None && GetAsyncKeyState(shiftModIncrSliderKey) == 0 ? KeyState.Up : newIncrSliderKeyState;
                newIncrSliderKeyState = altModIncrSliderKey != Keys.None && GetAsyncKeyState(altModIncrSliderKey) == 0 ? KeyState.Up : newIncrSliderKeyState;

                KeyState newDecrSliderKeyState = KeyState.Down;
                newDecrSliderKeyState = GetAsyncKeyState(decrSliderKey) == 0 ? KeyState.Up : newDecrSliderKeyState;
                newDecrSliderKeyState = controlModDecrSliderKey != Keys.None && GetAsyncKeyState(controlModDecrSliderKey) == 0 ? KeyState.Up : newDecrSliderKeyState;
                newDecrSliderKeyState = shiftModDecrSliderKey != Keys.None && GetAsyncKeyState(shiftModDecrSliderKey) == 0 ? KeyState.Up : newDecrSliderKeyState;
                newDecrSliderKeyState = altModDecrSliderKey != Keys.None && GetAsyncKeyState(altModDecrSliderKey) == 0 ? KeyState.Up : newDecrSliderKeyState;

                // Checks if the 'incrSliderKey' was 'Up' when last checked and if its now 'Down'
                if (incrSliderKeyState == KeyState.Up && newIncrSliderKeyState == KeyState.Down)
                {
                    Log("Increase-Slider-Key '" + incrSliderKey.ToString() + "' is now down...");
                    
                    incrSliderKeyState = KeyState.Down;
                    incrSliderKeyCurrDownTime = 0;
                }

                // Checks if the 'incrSliderKey' was 'Down' or 'HeldDown' when last checked and if its now up
                if (incrSliderKeyState == KeyState.Down && newIncrSliderKeyState == KeyState.Up)
                {
                    Log("Increase-Slider-Key '" + incrSliderKey.ToString() + "' is now up...");
                    
                    incrSliderKeyState = KeyState.Up;
                    incrSliderKeyCurrDownTime = 0;
                }

                // Checks if the 'decrSliderKey' was 'Up' when last checked and if its now 'Down'
                if (decrSliderKeyState == KeyState.Up && newDecrSliderKeyState == KeyState.Down)
                {
                    Log("Decrease-Slider-Key '" + decrSliderKey.ToString() + "' is now down...");
                    
                    decrSliderKeyState = KeyState.Down;
                    decrSliderKeyCurrDownTime = 0;
                }

                // Checks if the 'decrSliderKey' was 'Down' or 'HeldDown' when last checked and if its now up
                if (decrSliderKeyState == KeyState.Down && newDecrSliderKeyState == KeyState.Up)
                {
                    Log("Decrease-Slider-Key '" + decrSliderKey.ToString() + "' is now up...");
                    
                    decrSliderKeyState = KeyState.Up;
                    decrSliderKeyCurrDownTime = 0;
                }

                // 'hold down logic':

                // Increases the current down time of the key if its state is 'Down'
                if (incrSliderKeyState == KeyState.Down)
                {
                    incrSliderKeyCurrDownTime += inputCheckTimer.Interval;
                }

                // Increases the slider if its state is 'Down' and the currDownTime reached the holdTickIntervalSlider
                if (incrSliderKeyState == KeyState.Down && incrSliderKeyCurrDownTime >= holdTickIntervalSlider)
                {
                    incrSliderKeyCurrDownTime = 0;
                    CurrSliderValue += holdSliderDeltaPerTick;
                    UpdateSliderInVJoyDriver();
                }

                // Increases the current down time of the key if its state is 'Down'
                if (decrSliderKeyState == KeyState.Down)
                {
                    decrSliderKeyCurrDownTime += inputCheckTimer.Interval;
                }

                // Increases the slider if its state is 'Down' and the currDownTime reached the holdTickIntervalSlider
                if (decrSliderKeyState == KeyState.Down && decrSliderKeyCurrDownTime >= holdTickIntervalSlider)
                {
                    decrSliderKeyCurrDownTime = 0;
                    CurrSliderValue -= holdSliderDeltaPerTick;
                    UpdateSliderInVJoyDriver();
                }
            }
            #endregion
        }

        private void sliderTrackBar_Scroll(object sender, EventArgs e)
        {
            // Returns if the programm is currently not feeding
            if (CurrState != FeederState.Feeding) return;
            
            CurrSliderValue = (int)(MaxSliderValue * (sliderTrackBar.Value / 100f));
            UpdateSliderInVJoyDriver();
        }

        private void mappingThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sliderLevelsForm.Visible)
            {
                sliderLevelsForm.BringToFront();
            }
            else
            {
                sliderLevelsForm.Show();
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settingsForm.Visible)
            {
                settingsForm.BringToFront();
            }
            else
            {
                settingsForm.Show();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aboutForm.Visible)
            {
                aboutForm.BringToFront();
            }
            else
            {
                aboutForm.Show();
            }
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (instructionsForm.Visible)
            {
                instructionsForm.BringToFront();
            }
            else
            {
                instructionsForm.Show();
            }
        }

        private void saveSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void debugModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            InDebugMode = debugModeCheckBox.Checked;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Relinquishs the current joystick if there is one aquired
            if (currJoystickId != 0)
            {
                vJoyDriver.RelinquishVJD(currJoystickId);
            }
        }

        #endregion
    }

    public enum FeederState { SettingUp, NoVJoyDevice, ReadyToFeed, Feeding };

    public enum KeyState { Up, Down, HeldDown };
}