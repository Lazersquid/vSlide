using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace myFirstVJoyFeeder
{
    public partial class SettingsForm : Form
    {
        #region Fields

        MainForm mainForm;
        SettingsFormState currState = SettingsFormState.SettingUp;

        #endregion

        public SettingsForm(MainForm mainForm, List<uint> availableVJoyIds)
        {
            InitializeComponent();

            this.mainForm = mainForm;

            // Sets the key-bind comboboxes to the default values
            controlModNextLevelComboBox.SelectedItem = KeyToString(mainForm.ControlModNextLevelKey);
            shiftModNextLevelComboBox.SelectedItem = KeyToString(mainForm.ShiftModNextLevelKey);
            altModNextLevelComboBox.SelectedItem = KeyToString(mainForm.AltModNextLevelKey);
            nextLevelComboBox.SelectedItem = KeyToString(mainForm.NextLevelKey);

            controlModPrevLevelComboBox.SelectedItem = KeyToString(mainForm.ControlModPrevLevelKey);
            shiftModPrevLevelComboBox.SelectedItem = KeyToString(mainForm.ShiftModPrevLevelKey);
            altModPrevLevelComboBox.SelectedItem = KeyToString(mainForm.AltModPrevLevelKey);
            prevLevelComboBox.SelectedItem = KeyToString(mainForm.PrevLevelKey);
            
            controlModIncrSliderComboBox.SelectedItem = KeyToString(mainForm.ControlModIncrSliderKey);
            shiftModIncrSliderComboBox.SelectedItem = KeyToString(mainForm.ShiftModIncrSliderKey);
            altModIncrSliderComboBox.SelectedItem = KeyToString(mainForm.AltModIncrSliderKey);
            incrSliderComboBox.SelectedItem = KeyToString(mainForm.IncrSliderKey);
            
            controlModDecrSliderComboBox.SelectedItem = KeyToString(mainForm.ControlModDecrSliderKey);
            shiftModDecrSliderComboBox.SelectedItem = KeyToString(mainForm.ShiftModDecrSliderKey);
            altModDecrSliderComboBox.SelectedItem = KeyToString(mainForm.AltModDecrSliderKey);
            decrSliderComboBox.SelectedItem = KeyToString(mainForm.DecrSliderKey);

            // Adds all free or busy vJoy joysticks to the 'devicesComboBox' and updates the groupBox
            foreach (uint id in availableVJoyIds)
            {
                devicesComboBox.Items.Add(id);
            }
            UpdateVJoyDeviceGroupBox(mainForm.CurrJoystickId, mainForm.MaxSliderValue);
            mainForm.NewJoystickAcquired += UpdateVJoyDeviceGroupBox;

            // Sets the state to idle and updates the form
            currState = SettingsFormState.Idle;
            UpdateSettingsFormControls();
        }

        #region Methods

        public void UpdateSettingsFormControls()
        {
            // Makes sure the form currently is in idle
            if (currState != SettingsFormState.Idle) return;

            mainForm.Log("Updating the controls in the settings form...");
            currState = SettingsFormState.UpdatingForm;

            mainForm.HoldTresholdLevel = 0;
            mainForm.HoldTickIntervalLevel = 0;

            mainForm.HoldTresholdLevel = 0;
            mainForm.HoldTickIntervalLevel = 0;
            mainForm.HoldSliderDeltaPerTick = 0;

            // Key Setup
            #region Use Level Keys Only
            if (useLevelKeysOnlyRadioButton.Checked)
            {
                mainForm.IsUsingLevelKeys = true;
                mainForm.IsUsingSliderKeys = false;
                mainForm.HoldDownModeSlider = KeyHoldDownMode.None;
                levelKeysOnlyPanel.Enabled = true;

                if (holdLevelLPRadioButton.Checked)
                {
                    mainForm.HoldDownModeLevel = KeyHoldDownMode.Level;

                    // Ensures that the 'pressTresholdHoldLevelLPNumericUpDown' value is dividable by 5
                    pressTresholdHoldLevelLPNumericUpDown.Value -= pressTresholdHoldLevelLPNumericUpDown.Value % 5;
                    mainForm.HoldTresholdLevel = (int)pressTresholdHoldLevelLPNumericUpDown.Value;

                    // Ensures that the 'tickIntervalHoldLevelLPNumericUpDown' value is dividable by 5
                    tickIntervalHoldLevelLPNumericUpDown.Value -= tickIntervalHoldLevelLPNumericUpDown.Value % 5;
                    mainForm.HoldTickIntervalLevel = (int)tickIntervalHoldLevelLPNumericUpDown.Value;
                    holdDownLPPanel.Enabled = true;
                }
                else { holdDownLPPanel.Enabled = false; }

                if (holdSliderLPRadioButton.Checked)
                {
                    mainForm.HoldDownModeLevel = KeyHoldDownMode.Slider;

                    // Ensures that the 'pressTresholdHoldSliderLPNumericUpDown' value is dividable by 5
                    pressTresholdHoldSliderLPNumericUpDown.Value -= pressTresholdHoldSliderLPNumericUpDown.Value % 5;
                    mainForm.HoldTresholdLevel = (int)pressTresholdHoldSliderLPNumericUpDown.Value;

                    // Ensures that the 'tickIntervalHoldSliderLPNumericUpDown' value is dividable by 5
                    tickIntervalHoldSliderLPNumericUpDown.Value -= tickIntervalHoldSliderLPNumericUpDown.Value % 5;
                    mainForm.HoldTickIntervalLevel = (int)tickIntervalHoldSliderLPNumericUpDown.Value;
                    mainForm.HoldSliderDeltaPerTick = (int)sliderDeltaHoldSliderLPNumericUpDown.Value;
                    holdSliderLPPanel.Enabled = true;
                }
                else { holdSliderLPPanel.Enabled = false; }

                if (doNothingLPRadioButton.Checked)
                {
                    mainForm.HoldDownModeLevel = KeyHoldDownMode.None;
                }

            } else { levelKeysOnlyPanel.Enabled = false; }
            #endregion

            #region Use Both
            if (useBothKeysRadioButton.Checked)
            {
                mainForm.IsUsingLevelKeys = true;
                mainForm.IsUsingSliderKeys = true;
                mainForm.HoldDownModeSlider = KeyHoldDownMode.None;
                mainForm.HoldTresholdSlider = 0;

                // Ensures that the 'tickIntervalSliderSystemBPNumericUpDown' value is dividable by 5
                tickIntervalSliderSystemBPNumericUpDown.Value -= tickIntervalSliderSystemBPNumericUpDown.Value % 5;
                mainForm.HoldTickIntervalSlider = (int)tickIntervalSliderSystemBPNumericUpDown.Value;
                mainForm.HoldSliderDeltaPerTick = (int)sliderDeltaSliderSystemBPNumericUpDown.Value;
                bothKeysPanel.Enabled = true;

                if (useHoldDownLevelSystemBPGroupBox.Checked)
                {
                    mainForm.HoldDownModeLevel = KeyHoldDownMode.Level;

                    // Ensures that the 'pressTresholdLevelSystemBPNumericUpDown' value is dividable by 5
                    pressTresholdLevelSystemBPNumericUpDown.Value -= pressTresholdLevelSystemBPNumericUpDown.Value % 5;
                    mainForm.HoldTresholdLevel = (int)pressTresholdLevelSystemBPNumericUpDown.Value;

                    // Ensures that the 'tickIntervalLevelSystemBPNumericUpDown' value is dividable by 5
                    tickIntervalLevelSystemBPNumericUpDown.Value -= tickIntervalLevelSystemBPNumericUpDown.Value % 5;
                    mainForm.HoldTickIntervalLevel = (int)tickIntervalLevelSystemBPNumericUpDown.Value;
                    levelSystemBPGroupBox.Enabled = true;
                }
                else
                {
                    mainForm.HoldDownModeLevel = KeyHoldDownMode.None;
                    levelSystemBPGroupBox.Enabled = false;
                }
            }
            else { bothKeysPanel.Enabled = false; }
            #endregion

            #region Use SliderKeys Only
            if (useSliderKeysOnlyRadioButton.Checked)
            {
                mainForm.IsUsingLevelKeys = false;
                mainForm.IsUsingSliderKeys = true;
                mainForm.HoldDownModeSlider = KeyHoldDownMode.None;
                mainForm.HoldTresholdSlider = 0;

                // Ensures that the 'tickIntervalSPNumericUpDown' value is dividable by 5
                tickIntervalSPNumericUpDown.Value -= tickIntervalSPNumericUpDown.Value % 5;
                mainForm.HoldTickIntervalSlider = (int)tickIntervalSPNumericUpDown.Value;
                mainForm.HoldSliderDeltaPerTick = (int)sliderDeltaSPNumericUpDown.Value;
                sliderKeysOnlyPanel.Enabled = true;
            }
            else { sliderKeysOnlyPanel.Enabled = false; }
            #endregion

            // Key Binds
            levelKeyBindsGroupBox.Enabled = mainForm.IsUsingLevelKeys;
            sliderKeyBindsGroupBox.Enabled = mainForm.IsUsingSliderKeys;

            currState = SettingsFormState.Idle;
        }

        public void UpdateVJoyDeviceGroupBox(uint newJoystickId, int newMaxSliderValue)
        {
            if (newJoystickId == 0)
            {
                // Changes the selected combox item to force a call of
                // the 'devicesComboBox_SelectedIndexChanged' method
                if (devicesComboBox.Items.Count > 1)
                    devicesComboBox.SelectedIndex = 1;
                devicesComboBox.SelectedIndex = 0;
                acquiredDeviceIdLabel.Text = "None";
            }
            else
            {
                // Changes the selected combox item to force a call of
                // the 'devicesComboBox_SelectedIndexChanged' method
                devicesComboBox.SelectedIndex = 0;
                devicesComboBox.SelectedItem = newJoystickId;
                acquiredDeviceIdLabel.Text = newJoystickId.ToString();
            }
        }

        public Keys StringToKey (string keyName)
        {
            switch (keyName)
            {
                case "A":
                    return Keys.A;
                case "B":
                    return Keys.B;
                case "C":
                    return Keys.C;
                case "D":
                    return Keys.D;
                case "E":
                    return Keys.E;
                case "F":
                    return Keys.F;
                case "G":
                    return Keys.G;
                case "H":
                    return Keys.H;
                case "I":
                    return Keys.I;
                case "J":
                    return Keys.J;
                case "K":
                    return Keys.K;
                case "L":
                    return Keys.L;
                case "M":
                    return Keys.M;
                case "N":
                    return Keys.N;
                case "O":
                    return Keys.O;
                case "P":
                    return Keys.P;
                case "Q":
                    return Keys.Q;
                case "R":
                    return Keys.R;
                case "S":
                    return Keys.S;
                case "T":
                    return Keys.T;
                case "U":
                    return Keys.U;
                case "V":
                    return Keys.V;
                case "W":
                    return Keys.W;
                case "X":
                    return Keys.X;
                case "Y":
                    return Keys.Y;
                case "Z":
                    return Keys.Z;
                case "Control":
                    return Keys.ControlKey;
                case "Control Left":
                    return Keys.LControlKey;
                case "Control Right":
                    return Keys.RControlKey;
                case "Shift":
                    return Keys.ShiftKey;
                case "Shift Left":
                    return Keys.LShiftKey;
                case "Shift Right":
                    return Keys.RShiftKey;
                case "Alt":
                    return Keys.Menu;
                case "Alt Left":
                    return Keys.LMenu;
                case "Alt Right":
                    return Keys.RMenu;
                case "Capslock":
                    return Keys.CapsLock;
                default:
                    return Keys.None;
            }
        }

        public String KeyToString (Keys key)
        {
            switch (key)
            {
                case Keys.A:
                    return "A";
                case Keys.B:
                    return "B";
                case Keys.C:
                    return "C";
                case Keys.D:
                    return "D";
                case Keys.E:
                    return "E";
                case Keys.F:
                    return "F";
                case Keys.G:
                    return "G";
                case Keys.H:
                    return "H";
                case Keys.I:
                    return "I";
                case Keys.J:
                    return "J";
                case Keys.K:
                    return "K";
                case Keys.L:
                    return "L";
                case Keys.M:
                    return "M";
                case Keys.N:
                    return "N";
                case Keys.O:
                    return "O";
                case Keys.P:
                    return "P";
                case Keys.Q:
                    return "Q";
                case Keys.R:
                    return "R";
                case Keys.S:
                    return "S";
                case Keys.T:
                    return "T";
                case Keys.U:
                    return "U";
                case Keys.V:
                    return "V";
                case Keys.W:
                    return "W";
                case Keys.X:
                    return "X";
                case Keys.Y:
                    return "Y";
                case Keys.Z:
                    return "Z";
                case Keys.ControlKey:
                    return "Control";
                case Keys.LControlKey:
                    return "Control Left";
                case Keys.RControlKey:
                    return "Control Right";
                case Keys.ShiftKey:
                    return "Shift";
                case Keys.LShiftKey:
                    return "Shift Left";
                case Keys.RShiftKey:
                    return "Shift Right";
                case Keys.Menu:
                    return "Alt";
                case Keys.LMenu:
                    return "Alt Left";
                case Keys.RMenu:
                    return "Alt Right";
                case Keys.CapsLock:
                    return "Capslock";
                default:
                    return "None";
            }
        }

        public void SwapKeys (Keys key1, Keys key2)
        {
            Keys temp = key1;
            key1 = key2;
            key2 = temp;
        }

        #endregion

        #region Event Methods

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Hides the form instead of closing it
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void devicesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Checks if 'None' is selected
            if (devicesComboBox.SelectedIndex == 0)
            {
                deviceStatusLabel.Text = "-";
                acquireDeviceButton.Enabled = false;
            }
            else
            {
                // Gets the selected device id
                uint deviceId = (uint)devicesComboBox.SelectedItem;

                // Gets the status of the selected device
                VjdStat status = mainForm.vJoyDriver.GetVJDStatus(deviceId);

                // Saves the status to the 'deviceStatusLabel'
                deviceStatusLabel.Text = mainForm.VjdStatToString(status);

                // Enable the 'acquireDeviceButton' if the device is free
                if (status == VjdStat.VJD_STAT_FREE)
                {
                    acquireDeviceButton.Enabled = true;
                }
                else
                {
                    acquireDeviceButton.Enabled = false;
                }
            }
        }

        private void acquireDeviceButton_Click(object sender, EventArgs e)
        {
            // Gets the selected device id
            uint deviceId = (uint)devicesComboBox.SelectedItem;

            mainForm.AcquireNewJoystick(deviceId);
        }

        private void RadioButtonOrCheckBox_ValueChanged(object sender, EventArgs e)
        {
            UpdateSettingsFormControls();
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateSettingsFormControls();
        }

        private void KeyBindComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ignores the call if the form is still stetting up
            if(currState == SettingsFormState.SettingUp) { return; }

            // Casts the sender into a ComboBox, this never fails since this method is only added
            // to the events of combo boxes
            ComboBox senderComboBox = (ComboBox)sender;
            mainForm.Log("The key bind of the ComboBox '" + senderComboBox.Name + "' was changed, determing new key-value...");

            // Gets the selected key and casts it into a string
            string newValue = (string)senderComboBox.SelectedItem;
            // Determines the respective Keys value
            Keys newKey = StringToKey(newValue);

            mainForm.Log("Determined key-value '" + newKey + "' from the selected string '"+ newValue + "'");

            // Checks which key bind ComboBox's SelectedIndex changed:
            // Next level comboBox's
            if (senderComboBox.Name == "controlModNextLevelComboBox")
            {
                // Returns if the key is already bound to that key
                if (mainForm.ControlModNextLevelKey == newKey)
                {
                    mainForm.Log("The controlModNextLevelKey is already bound to that key, returning...");
                    return;
                }
                // Checks if the nextLevelKey is already bound to a control key and if the newKey is a control key aswell
                if ((mainForm.NextLevelKey == Keys.ControlKey || mainForm.NextLevelKey == Keys.LControlKey || mainForm.NextLevelKey == Keys.RControlKey) && newKey != Keys.None)
                {
                    controlModNextLevelComboBox.SelectedItem = "None";
                }
                else
                {
                    mainForm.ControlModNextLevelKey = newKey;
                }
            }
            else if (senderComboBox.Name == "shiftModNextLevelComboBox")
            {
                // Returns if the key is already bound to that key
                if (mainForm.ShiftModNextLevelKey == newKey)
                {
                    mainForm.Log("The shiftModNextLevelKey is already bound to that key, returning...");
                    return;
                }
                // Checks if the nextLevelKey is already bound to a shift key and if the newKey is a shift key aswell
                if ((mainForm.NextLevelKey == Keys.ShiftKey || mainForm.NextLevelKey == Keys.LShiftKey || mainForm.NextLevelKey == Keys.RShiftKey) && newKey != Keys.None)
                {
                    shiftModNextLevelComboBox.SelectedItem = "None";
                }
                else
                {
                    mainForm.ShiftModNextLevelKey = newKey;
                }
            }
            else if (senderComboBox.Name == "altModNextLevelComboBox")
            {
                // Returns if the key is already bound to that key
                if (mainForm.AltModNextLevelKey == newKey)
                {
                    mainForm.Log("The altModNextLevelKey is already bound to that key, returning...");
                    return;
                }
                // Checks if the nextLevelKey is already bound to a alt key and if the newKey is a alt key aswell
                if ((mainForm.NextLevelKey == Keys.Menu || mainForm.NextLevelKey == Keys.LMenu || mainForm.NextLevelKey == Keys.RMenu) && newKey != Keys.None)
                {
                    altModNextLevelComboBox.SelectedItem = "None";
                }
                else
                {
                    mainForm.AltModNextLevelKey = newKey;
                }
            }
            else if (senderComboBox.Name == "nextLevelComboBox")
            {
                // Returns if the key is already bound to that key
                if (mainForm.NextLevelKey == newKey)
                {
                    mainForm.Log("The nextLevelKey is already bound to that key, returning...");
                    return;
                }

                // Checks if the ControlModNextLevelKey is bound to a control key and if the newKey is a control key aswell
                if (mainForm.ControlModNextLevelKey != Keys.None && (newKey == Keys.ControlKey || newKey == Keys.LControlKey || newKey == Keys.RControlKey))
                {
                    controlModNextLevelComboBox.SelectedItem = "None";
                }
                // Checks if the ShiftModNextLevelKey is bound to a shift key and if the newKey is a shift key aswell
                else if (mainForm.ShiftModNextLevelKey != Keys.None && (newKey == Keys.ShiftKey || newKey == Keys.LShiftKey || newKey == Keys.RShiftKey))
                {
                    shiftModNextLevelComboBox.SelectedItem = "None";
                }
                // Checks if the AltModNextLevelKey is bound to a alt key and if the newKey is a alt key aswell
                else if (mainForm.AltModNextLevelKey != Keys.None && (newKey == Keys.Menu || newKey == Keys.LMenu || newKey == Keys.RMenu))
                {
                    altModNextLevelComboBox.SelectedItem = "None";
                }

                // Gets the name of the key that the nextLevelKey currently has
                string oldKeyName = KeyToString(mainForm.NextLevelKey);
                // Checks if another key is already bound to that key and swaps the keys
                if (mainForm.PrevLevelKey == newKey)
                {
                    prevLevelComboBox.SelectedItem = oldKeyName;
                }
                if (mainForm.IncrSliderKey == newKey)
                {
                    incrSliderComboBox.SelectedItem = oldKeyName;
                }
                if (mainForm.DecrSliderKey == newKey)
                {
                    decrSliderComboBox.SelectedItem = oldKeyName;
                }
                mainForm.NextLevelKey = newKey;
            }

            // Previous level comboBox's
            else if (senderComboBox.Name == "controlModPrevLevelComboBox")
            {
                // Returns if the key is already bound to that key
                if (mainForm.ControlModPrevLevelKey == newKey)
                {
                    mainForm.Log("The controlModPrevLevelKey is already bound to that key, returning...");
                    return;
                }
                // Checks if the PrevLevelKey is already bound to a control key and if the newKey is a control key aswell
                if ((mainForm.PrevLevelKey == Keys.ControlKey || mainForm.PrevLevelKey == Keys.LControlKey || mainForm.PrevLevelKey == Keys.RControlKey) && newKey != Keys.None)
                {
                    controlModPrevLevelComboBox.SelectedItem = "None";
                }
                else
                {
                    mainForm.ControlModPrevLevelKey = newKey;
                }
            }
            else if (senderComboBox.Name == "shiftModPrevLevelComboBox")
            {
                // Returns if the key is already bound to that key
                if (mainForm.ShiftModPrevLevelKey == newKey)
                {
                    mainForm.Log("The shiftModPrevLevelKey is already bound to that key, returning...");
                    return;
                }
                // Checks if the PrevLevelKey is already bound to a shift key and if the newKey is a shift key aswell
                if ((mainForm.PrevLevelKey == Keys.ShiftKey || mainForm.PrevLevelKey == Keys.LShiftKey || mainForm.PrevLevelKey == Keys.RShiftKey) && newKey != Keys.None)
                {
                    shiftModPrevLevelComboBox.SelectedItem = "None";
                }
                else
                {
                    mainForm.ShiftModPrevLevelKey = newKey;
                }
            }
            else if (senderComboBox.Name == "altModPrevLevelComboBox")
            {
                // Returns if the key is already bound to that key
                if (mainForm.AltModPrevLevelKey == newKey)
                {
                    mainForm.Log("The altModPrevLevelKey is already bound to that key, returning...");
                    return;
                }
                // Checks if the PrevLevelKey is already bound to a alt key and if the newKey is a alt key aswell
                if ((mainForm.PrevLevelKey == Keys.Menu || mainForm.PrevLevelKey == Keys.LMenu || mainForm.PrevLevelKey == Keys.RMenu) && newKey != Keys.None)
                {
                    altModPrevLevelComboBox.SelectedItem = "None";
                }
                else
                {
                    mainForm.AltModPrevLevelKey = newKey;
                }
            }
            else if (senderComboBox.Name == "prevLevelComboBox")
            {
                // Returns if the key is already bound to that key
                if (mainForm.PrevLevelKey == newKey)
                {
                    mainForm.Log("The prevLevelKey is already bound to that key, returning...");
                    return;
                }

                // Checks if the ControlModPrevLevelKey is bound to a control key and if the newKey is a control key aswell
                if (mainForm.ControlModPrevLevelKey != Keys.None && (newKey == Keys.ControlKey || newKey == Keys.LControlKey || newKey == Keys.RControlKey))
                {
                    controlModPrevLevelComboBox.SelectedItem = "None";
                }
                // Checks if the ShiftModPrevLevelKey is bound to a shift key and if the newKey is a shift key aswell
                else if (mainForm.ShiftModPrevLevelKey != Keys.None && (newKey == Keys.ShiftKey || newKey == Keys.LShiftKey || newKey == Keys.RShiftKey))
                {
                    shiftModPrevLevelComboBox.SelectedItem = "None";
                }
                // Checks if the AltModPrevLevelKey is bound to a alt key and if the newKey is a alt key aswell
                else if (mainForm.AltModPrevLevelKey != Keys.None && (newKey == Keys.Menu || newKey == Keys.LMenu || newKey == Keys.RMenu))
                {
                    altModPrevLevelComboBox.SelectedItem = "None";
                }

                // Gets the name of the key that the prevLevelKey currently has
                string oldKeyName = KeyToString(mainForm.PrevLevelKey);
                // Checks if another key is already bound to that key and swaps the keys
                if (mainForm.NextLevelKey == newKey)
                {
                    nextLevelComboBox.SelectedItem = oldKeyName;
                }
                if (mainForm.IncrSliderKey == newKey)
                {
                    incrSliderComboBox.SelectedItem = oldKeyName;
                }
                if (mainForm.DecrSliderKey == newKey)
                {
                    decrSliderComboBox.SelectedItem = oldKeyName;
                }
                mainForm.PrevLevelKey = newKey;
            }

            // Increase slider comboBox's
            else if (senderComboBox.Name == "controlModIncrSliderComboBox")
            {
                // Returns if the key is already bound to that key
                if (mainForm.ControlModIncrSliderKey == newKey)
                {
                    mainForm.Log("The controlModIncrSliderKey is already bound to that key, returning...");
                    return;
                }
                // Checks if the incrSliderKey is already bound to a control key and if the newKey is a control key aswell
                if ((mainForm.IncrSliderKey == Keys.ControlKey || mainForm.IncrSliderKey == Keys.LControlKey || mainForm.IncrSliderKey == Keys.RControlKey) && newKey != Keys.None)
                {
                    controlModIncrSliderComboBox.SelectedItem = "None";
                }
                else
                {
                    mainForm.ControlModIncrSliderKey = newKey;
                }
            }
            else if (senderComboBox.Name == "shiftModIncrSliderComboBox")
            {
                // Returns if the key is already bound to that key
                if (mainForm.ShiftModIncrSliderKey == newKey)
                {
                    mainForm.Log("The shiftModIncrSliderKey is already bound to that key, returning...");
                    return;
                }
                // Checks if the incrSliderKey is already bound to a shift key and if the newKey is a shift key aswell
                if ((mainForm.IncrSliderKey == Keys.ShiftKey || mainForm.IncrSliderKey == Keys.LShiftKey || mainForm.IncrSliderKey == Keys.RShiftKey) && newKey != Keys.None)
                {
                    shiftModIncrSliderComboBox.SelectedItem = "None";
                }
                else
                {
                    mainForm.ShiftModIncrSliderKey = newKey;
                }
            }
            else if (senderComboBox.Name == "altModIncrSliderComboBox")
            {
                // Returns if the key is already bound to that key
                if (mainForm.AltModIncrSliderKey == newKey)
                {
                    mainForm.Log("The altModIncrSliderKey is already bound to that key, returning...");
                    return;
                }
                // Checks if the incrSliderKey is already bound to a alt key and if the newKey is a alt key aswell
                if ((mainForm.IncrSliderKey == Keys.Menu || mainForm.IncrSliderKey == Keys.LMenu || mainForm.IncrSliderKey == Keys.RMenu) && newKey != Keys.None)
                {
                    altModIncrSliderComboBox.SelectedItem = "None";
                }
                else
                {
                    mainForm.AltModIncrSliderKey = newKey;
                }
            }
            else if (senderComboBox.Name == "incrSliderComboBox")
            {
                // Returns if the key is already bound to that key
                if (mainForm.IncrSliderKey == newKey)
                {
                    mainForm.Log("The incrSliderKey is already bound to that key, returning...");
                    return;
                }

                // Checks if the ControlModIncrSliderKey is bound to a control key and if the newKey is a control key aswell
                if (mainForm.ControlModIncrSliderKey != Keys.None && (newKey == Keys.ControlKey || newKey == Keys.LControlKey || newKey == Keys.RControlKey))
                {
                    controlModIncrSliderComboBox.SelectedItem = "None";
                }
                // Checks if the ShiftModIncrSliderKey is bound to a shift key and if the newKey is a shift key aswell
                else if (mainForm.ShiftModIncrSliderKey != Keys.None && (newKey == Keys.ShiftKey || newKey == Keys.LShiftKey || newKey == Keys.RShiftKey))
                {
                    shiftModIncrSliderComboBox.SelectedItem = "None";
                }
                // Checks if the AltModIncrSliderKey is bound to a alt key and if the newKey is a alt key aswell
                else if (mainForm.AltModIncrSliderKey != Keys.None && (newKey == Keys.Menu || newKey == Keys.LMenu || newKey == Keys.RMenu))
                {
                    altModIncrSliderComboBox.SelectedItem = "None";
                }

                // Gets the name of the key that the incrSliderKey currently has
                string oldKeyName = KeyToString(mainForm.IncrSliderKey);
                // Checks if another key is already bound to that key and swaps the keys
                if (mainForm.NextLevelKey == newKey)
                {
                    nextLevelComboBox.SelectedItem = oldKeyName;
                }
                if (mainForm.PrevLevelKey == newKey)
                {
                    prevLevelComboBox.SelectedItem = oldKeyName;
                }
                if (mainForm.DecrSliderKey == newKey)
                {
                    decrSliderComboBox.SelectedItem = oldKeyName;
                }
                mainForm.IncrSliderKey = newKey;
            }

            // Decrease slider comboBox's
            else if (senderComboBox.Name == "controlModDecrSliderComboBox")
            {
                // Returns if the key is already bound to that key
                if (mainForm.ControlModDecrSliderKey == newKey)
                {
                    mainForm.Log("The controlModDecrSliderKey is already bound to that key, returning...");
                    return;
                }
                // Checks if the decrSliderKey is already bound to a control key and if the newKey is a control key aswell
                if ((mainForm.DecrSliderKey == Keys.ControlKey || mainForm.DecrSliderKey == Keys.LControlKey || mainForm.DecrSliderKey == Keys.RControlKey) && newKey != Keys.None)
                {
                    controlModDecrSliderComboBox.SelectedItem = "None";
                }
                else
                {
                    mainForm.ControlModDecrSliderKey = newKey;
                }
            }
            else if (senderComboBox.Name == "shiftModDecrSliderComboBox")
            {                
                // Returns if the key is already bound to that key
                if (mainForm.ShiftModDecrSliderKey == newKey)
                {
                    mainForm.Log("The shiftModDecrSliderKey is already bound to that key, returning...");
                    return;
                }
                // Checks if the decrSliderKey is already bound to a shift key and if the newKey is a shift key aswell
                if ((mainForm.DecrSliderKey == Keys.ShiftKey || mainForm.DecrSliderKey == Keys.LShiftKey || mainForm.DecrSliderKey == Keys.RShiftKey) && newKey != Keys.None)
                {
                    shiftModDecrSliderComboBox.SelectedItem = "None";
                }
                else
                {
                    mainForm.ShiftModDecrSliderKey = newKey;
                }
            }
            else if (senderComboBox.Name == "altModDecrSliderComboBox")
            {
                // Returns if the key is already bound to that key
                if (mainForm.AltModDecrSliderKey == newKey)
                {
                    mainForm.Log("The altModDecrSliderKey is already bound to that key, returning...");
                    return;
                }
                // Checks if the decrSliderKey is already bound to a alt key and if the newKey is a alt key aswell
                if ((mainForm.DecrSliderKey == Keys.Menu || mainForm.DecrSliderKey == Keys.LMenu || mainForm.DecrSliderKey == Keys.RMenu) && newKey != Keys.None)
                {
                    altModDecrSliderComboBox.SelectedItem = "None";
                }
                else
                {
                    mainForm.AltModDecrSliderKey = newKey;
                }
            }
            else if (senderComboBox.Name == "decrSliderComboBox")
            {
                // Returns if the key is already bound to that key
                if (mainForm.DecrSliderKey == newKey)
                {
                    mainForm.Log("The decrSliderKey is already bound to that key, returning...");
                    return;
                }

                // Checks if the ControlModDecrSliderKey is bound to a control key and if the newKey is a control key aswell
                if (mainForm.ControlModDecrSliderKey != Keys.None && (newKey == Keys.ControlKey || newKey == Keys.LControlKey || newKey == Keys.RControlKey))
                {
                    controlModDecrSliderComboBox.SelectedItem = "None";
                }
                // Checks if the ShiftModDecrSliderKey is bound to a shift key and if the newKey is a shift key aswell
                else if (mainForm.ShiftModDecrSliderKey != Keys.None && (newKey == Keys.ShiftKey || newKey == Keys.LShiftKey || newKey == Keys.RShiftKey))
                {
                    shiftModDecrSliderComboBox.SelectedItem = "None";
                }
                // Checks if the AltModDecrSliderKey is bound to a alt key and if the newKey is a alt key aswell
                else if (mainForm.AltModDecrSliderKey != Keys.None && (newKey == Keys.Menu || newKey == Keys.LMenu || newKey == Keys.RMenu))
                {
                    altModDecrSliderComboBox.SelectedItem = "None";
                }

                // Gets the name of the key that the decrSliderKey currently has
                string oldKeyName = KeyToString(mainForm.DecrSliderKey);
                // Checks if another key is already bound to that key and swaps the keys
                if (mainForm.NextLevelKey == newKey)
                {
                    nextLevelComboBox.SelectedItem = oldKeyName;
                }
                if (mainForm.PrevLevelKey == newKey)
                {
                    prevLevelComboBox.SelectedItem = oldKeyName;
                }
                if (mainForm.IncrSliderKey == newKey)
                {
                    incrSliderComboBox.SelectedItem = oldKeyName;
                }
                mainForm.DecrSliderKey = newKey;
            }
        }

        #endregion
    }

    public enum KeyHoldDownMode { None, Level, Slider };
    public enum SettingsFormState { SettingUp, Idle, UpdatingForm, ApplyingChanges};
}
