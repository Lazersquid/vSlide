using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace vSlide
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
            controlModNextLevelComboBox.SelectedItem = KeyToString(mainForm.NextLevelKeyBind.ControlMod);
            shiftModNextLevelComboBox.SelectedItem = KeyToString(mainForm.NextLevelKeyBind.ShiftMod);
            altModNextLevelComboBox.SelectedItem = KeyToString(mainForm.NextLevelKeyBind.AltMod);
            nextLevelComboBox.SelectedItem = KeyToString(mainForm.NextLevelKeyBind.BoundKey);

            controlModPrevLevelComboBox.SelectedItem = KeyToString(mainForm.PrevLevelKeyBind.ControlMod);
            shiftModPrevLevelComboBox.SelectedItem = KeyToString(mainForm.PrevLevelKeyBind.ShiftMod);
            altModPrevLevelComboBox.SelectedItem = KeyToString(mainForm.PrevLevelKeyBind.AltMod);
            prevLevelComboBox.SelectedItem = KeyToString(mainForm.PrevLevelKeyBind.BoundKey);
            
            controlModIncrSliderComboBox.SelectedItem = KeyToString(mainForm.IncrSliderKeyBind.ControlMod);
            shiftModIncrSliderComboBox.SelectedItem = KeyToString(mainForm.IncrSliderKeyBind.ShiftMod);
            altModIncrSliderComboBox.SelectedItem = KeyToString(mainForm.IncrSliderKeyBind.AltMod);
            incrSliderComboBox.SelectedItem = KeyToString(mainForm.IncrSliderKeyBind.BoundKey);
            
            controlModDecrSliderComboBox.SelectedItem = KeyToString(mainForm.DecrSliderKeyBind.ControlMod);
            shiftModDecrSliderComboBox.SelectedItem = KeyToString(mainForm.DecrSliderKeyBind.ShiftMod);
            altModDecrSliderComboBox.SelectedItem = KeyToString(mainForm.DecrSliderKeyBind.AltMod);
            decrSliderComboBox.SelectedItem = KeyToString(mainForm.DecrSliderKeyBind.BoundKey);

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

            // New Key Setup
            uint holdTresholdLevel = 0;
            uint holdTickIntervalLevel = 0;
            if (mainForm.NextLevelKeyBind.UseHeldDown) { mainForm.NextLevelKeyBind.DisableHeldDown(); }
            if (mainForm.PrevLevelKeyBind.UseHeldDown) { mainForm.PrevLevelKeyBind.DisableHeldDown(); }
            
            uint holdTickIntervalSlider = 0;
            mainForm.HoldSliderDeltaPerTick = 0;
            if (mainForm.IncrSliderKeyBind.UseHeldDown) { mainForm.IncrSliderKeyBind.DisableHeldDown(); }
            if (mainForm.DecrSliderKeyBind.UseHeldDown) { mainForm.DecrSliderKeyBind.DisableHeldDown(); }


            #region Use Level Keys Only
            if (useLevelKeysOnlyRadioButton.Checked)
            {
                mainForm.IsUsingLevelKeys = true;
                mainForm.IsUsingSliderKeys = false;
                levelKeysOnlyPanel.Enabled = true;

                if (holdLevelLPRadioButton.Checked)
                {
                    mainForm.HoldDownModeLevel = KeyHoldDownMode.Level;

                    // Ensures that the 'pressTresholdHoldLevelLPNumericUpDown' value is dividable by 5
                    pressTresholdHoldLevelLPNumericUpDown.Value -= pressTresholdHoldLevelLPNumericUpDown.Value % 5;
                    holdTresholdLevel = (uint)pressTresholdHoldLevelLPNumericUpDown.Value;

                    // Ensures that the 'tickIntervalHoldLevelLPNumericUpDown' value is dividable by 5
                    tickIntervalHoldLevelLPNumericUpDown.Value -= tickIntervalHoldLevelLPNumericUpDown.Value % 5;
                    holdTickIntervalLevel = (uint)tickIntervalHoldLevelLPNumericUpDown.Value;
                    holdDownLPPanel.Enabled = true;
                }
                else { holdDownLPPanel.Enabled = false; }

                if (holdSliderLPRadioButton.Checked)
                {
                    mainForm.HoldDownModeLevel = KeyHoldDownMode.Slider;

                    // Ensures that the 'pressTresholdHoldSliderLPNumericUpDown' value is dividable by 5
                    pressTresholdHoldSliderLPNumericUpDown.Value -= pressTresholdHoldSliderLPNumericUpDown.Value % 5;
                    holdTresholdLevel = (uint)pressTresholdHoldSliderLPNumericUpDown.Value;

                    // Ensures that the 'tickIntervalHoldSliderLPNumericUpDown' value is dividable by 5
                    tickIntervalHoldSliderLPNumericUpDown.Value -= tickIntervalHoldSliderLPNumericUpDown.Value % 5;
                    holdTickIntervalLevel = (uint)tickIntervalHoldSliderLPNumericUpDown.Value;
                    mainForm.HoldSliderDeltaPerTick = (int)sliderDeltaHoldSliderLPNumericUpDown.Value;
                    holdSliderLPPanel.Enabled = true;
                }
                else { holdSliderLPPanel.Enabled = false; }

                if (doNothingLPRadioButton.Checked)
                {
                    mainForm.HoldDownModeLevel = KeyHoldDownMode.None;
                }

            }
            else { levelKeysOnlyPanel.Enabled = false; }
            #endregion

            #region Use Both
            if (useBothKeysRadioButton.Checked)
            {
                mainForm.IsUsingLevelKeys = true;
                mainForm.IsUsingSliderKeys = true;

                // Ensures that the 'tickIntervalSliderSystemBPNumericUpDown' value is dividable by 5
                tickIntervalSliderSystemBPNumericUpDown.Value -= tickIntervalSliderSystemBPNumericUpDown.Value % 5;
                holdTickIntervalSlider = (uint)tickIntervalSliderSystemBPNumericUpDown.Value;
                mainForm.HoldSliderDeltaPerTick = (int)sliderDeltaSliderSystemBPNumericUpDown.Value;
                bothKeysPanel.Enabled = true;

                if (useHoldDownLevelSystemBPGroupBox.Checked)
                {
                    mainForm.HoldDownModeLevel = KeyHoldDownMode.Level;

                    // Ensures that the 'pressTresholdLevelSystemBPNumericUpDown' value is dividable by 5
                    pressTresholdLevelSystemBPNumericUpDown.Value -= pressTresholdLevelSystemBPNumericUpDown.Value % 5;
                    holdTresholdLevel = (uint)pressTresholdLevelSystemBPNumericUpDown.Value;

                    // Ensures that the 'tickIntervalLevelSystemBPNumericUpDown' value is dividable by 5
                    tickIntervalLevelSystemBPNumericUpDown.Value -= tickIntervalLevelSystemBPNumericUpDown.Value % 5;
                    holdTickIntervalLevel = (uint)tickIntervalLevelSystemBPNumericUpDown.Value;
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

                // Ensures that the 'tickIntervalSPNumericUpDown' value is dividable by 5
                tickIntervalSPNumericUpDown.Value -= tickIntervalSPNumericUpDown.Value % 5;
                holdTickIntervalSlider = (uint)tickIntervalSPNumericUpDown.Value;
                mainForm.HoldSliderDeltaPerTick = (int)sliderDeltaSPNumericUpDown.Value;
                sliderKeysOnlyPanel.Enabled = true;
            }
            else { sliderKeysOnlyPanel.Enabled = false; }
            #endregion

            if (mainForm.HoldDownModeLevel != KeyHoldDownMode.None)
            {
                mainForm.NextLevelKeyBind.EnableHeldDown(holdTresholdLevel, holdTickIntervalLevel);
                mainForm.PrevLevelKeyBind.EnableHeldDown(holdTresholdLevel, holdTickIntervalLevel);
            }
            
            if (mainForm.IsUsingSliderKeys)
            {
                mainForm.IncrSliderKeyBind.EnableHeldDown(0, holdTickIntervalSlider);
                mainForm.DecrSliderKeyBind.EnableHeldDown(0, holdTickIntervalSlider);
            }
            
            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*
            // Old Key Setup
            mainForm.HoldTresholdLevel = 0;
            mainForm.HoldTickIntervalLevel = 0;

            mainForm.HoldTresholdSlider = 0;
            mainForm.HoldTickIntervalSlider = 0;
            mainForm.HoldSliderDeltaPerTick = 0;

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
            */

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

        public void SyncUIToKeybinds()
        {
            SettingsFormState oldState = currState;
            currState = SettingsFormState.UpdatingKeyBinds;

            // Next level key bind
            controlModNextLevelComboBox.SelectedItem = KeyToString(mainForm.NextLevelKeyBind.ControlMod);
            shiftModNextLevelComboBox.SelectedItem = KeyToString(mainForm.NextLevelKeyBind.ShiftMod);
            altModNextLevelComboBox.SelectedItem = KeyToString(mainForm.NextLevelKeyBind.AltMod);
            nextLevelComboBox.SelectedItem = KeyToString(mainForm.NextLevelKeyBind.BoundKey);

            // Previous level key bind
            controlModPrevLevelComboBox.SelectedItem = KeyToString(mainForm.PrevLevelKeyBind.ControlMod);
            shiftModPrevLevelComboBox.SelectedItem = KeyToString(mainForm.PrevLevelKeyBind.ShiftMod);
            altModPrevLevelComboBox.SelectedItem = KeyToString(mainForm.PrevLevelKeyBind.AltMod);
            prevLevelComboBox.SelectedItem = KeyToString(mainForm.PrevLevelKeyBind.BoundKey);

            // Increase slider key bind
            controlModIncrSliderComboBox.SelectedItem = KeyToString(mainForm.IncrSliderKeyBind.ControlMod);
            shiftModIncrSliderComboBox.SelectedItem = KeyToString(mainForm.IncrSliderKeyBind.ShiftMod);
            altModIncrSliderComboBox.SelectedItem = KeyToString(mainForm.IncrSliderKeyBind.AltMod);
            incrSliderComboBox.SelectedItem = KeyToString(mainForm.IncrSliderKeyBind.BoundKey);

            // Decrease slider key bind
            controlModDecrSliderComboBox.SelectedItem = KeyToString(mainForm.DecrSliderKeyBind.ControlMod);
            shiftModDecrSliderComboBox.SelectedItem = KeyToString(mainForm.DecrSliderKeyBind.ShiftMod);
            altModDecrSliderComboBox.SelectedItem = KeyToString(mainForm.DecrSliderKeyBind.AltMod);
            decrSliderComboBox.SelectedItem = KeyToString(mainForm.DecrSliderKeyBind.BoundKey);

            currState = oldState;
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
                case "1":
                    return Keys.D1;
                case "2":
                    return Keys.D2;
                case "3":
                    return Keys.D3;
                case "4":
                    return Keys.D4;
                case "5":
                    return Keys.D5;
                case "6":
                    return Keys.D6;
                case "7":
                    return Keys.D7;
                case "8":
                    return Keys.D8;
                case "9":
                    return Keys.D9;
                case "0":
                    return Keys.D0;
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
                case "Up":
                    return Keys.Up;
                case "Down":
                    return Keys.Down;
                case "Left":
                    return Keys.Left;
                case "Right":
                    return Keys.Right;
                case "Numlock":
                    return Keys.NumLock;
                case "Numpad 1":
                    return Keys.NumPad1;
                case "Numpad 2":
                    return Keys.NumPad2;
                case "Numpad 3":
                    return Keys.NumPad3;
                case "Numpad 4":
                    return Keys.NumPad4;
                case "Numpad 5":
                    return Keys.NumPad5;
                case "Numpad 6":
                    return Keys.NumPad6;
                case "Numpad 7":
                    return Keys.NumPad7;
                case "Numpad 8":
                    return Keys.NumPad8;
                case "Numpad 9":
                    return Keys.NumPad9;
                case "Numpad 0":
                    return Keys.NumPad0;
                case "Capslock":
                    return Keys.CapsLock;
                case "Tab":
                    return Keys.Tab;
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
                case Keys.D1:
                    return "1";
                case Keys.D2:
                    return "2";
                case Keys.D3:
                    return "3";
                case Keys.D4:
                    return "4";
                case Keys.D5:
                    return "5";
                case Keys.D6:
                    return "6";
                case Keys.D7:
                    return "7";
                case Keys.D8:
                    return "8";
                case Keys.D9:
                    return "9";
                case Keys.D0:
                    return "0";
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
                case Keys.Up:
                    return "Up";
                case Keys.Down:
                    return "Down";
                case Keys.Left:
                    return "Left";
                case Keys.Right:
                    return "Right";
                case Keys.NumLock:
                    return "Numlock";
                case Keys.NumPad1:
                    return "Numpad 1";
                case Keys.NumPad2:
                    return "Numpad 2";
                case Keys.NumPad3:
                    return "Numpad 3";
                case Keys.NumPad4:
                    return "Numpad 4";
                case Keys.NumPad5:
                    return "Numpad 5";
                case Keys.NumPad6:
                    return "Numpad 6";
                case Keys.NumPad7:
                    return "Numpad 7";
                case Keys.NumPad8:
                    return "Numpad 8";
                case Keys.NumPad9:
                    return "Numpad 9";
                case Keys.NumPad0:
                    return "Numpad 0";
                case Keys.CapsLock:
                    return "Capslock";
                case Keys.Tab:
                    return "Tab";
                case Keys.Crsel:
                    return "Crsel";
                default:
                    return "None";
            }
        }

        public void SaveCurrSettings()
        {
            try
            {
                // Saves key binds
                Properties.Settings.Default["nextLevelKey"] = KeyToString(mainForm.NextLevelKeyBind.BoundKey);
                Properties.Settings.Default["prevLevelKey"] = KeyToString(mainForm.PrevLevelKeyBind.BoundKey);
                Properties.Settings.Default["incrSliderKey"] = KeyToString(mainForm.IncrSliderKeyBind.BoundKey);
                Properties.Settings.Default["decrSliderKey"] = KeyToString(mainForm.DecrSliderKeyBind.BoundKey);

                Properties.Settings.Default["controlModNextLevelKey"] = KeyToString(mainForm.NextLevelKeyBind.ControlMod);
                Properties.Settings.Default["controlModPrevLevelKey"] = KeyToString(mainForm.PrevLevelKeyBind.ControlMod);
                Properties.Settings.Default["controlModIncrSliderKey"] = KeyToString(mainForm.IncrSliderKeyBind.ControlMod);
                Properties.Settings.Default["controlModDecrSliderKey"] = KeyToString(mainForm.DecrSliderKeyBind.ControlMod);

                Properties.Settings.Default["shiftModNextLevelKey"] = KeyToString(mainForm.NextLevelKeyBind.ShiftMod);
                Properties.Settings.Default["shiftModPrevLevelKey"] = KeyToString(mainForm.PrevLevelKeyBind.ShiftMod);
                Properties.Settings.Default["shiftModIncrSliderKey"] = KeyToString(mainForm.IncrSliderKeyBind.ShiftMod);
                Properties.Settings.Default["shiftModDecrSliderKey"] = KeyToString(mainForm.DecrSliderKeyBind.ShiftMod);

                Properties.Settings.Default["altModNextLevelKey"] = KeyToString(mainForm.NextLevelKeyBind.AltMod);
                Properties.Settings.Default["altModPrevLevelKey"] = KeyToString(mainForm.PrevLevelKeyBind.AltMod);
                Properties.Settings.Default["altModIncrSliderKey"] = KeyToString(mainForm.IncrSliderKeyBind.AltMod);
                Properties.Settings.Default["altModDecrSliderKey"] = KeyToString(mainForm.DecrSliderKeyBind.AltMod);

                // The checked RadioButton of the 'keySetupGroupBox'
                if (useLevelKeysOnlyRadioButton.Checked)
                {
                    Properties.Settings.Default["keySetupRadioButton"] = 1;
                }
                else if (useBothKeysRadioButton.Checked)
                {
                    Properties.Settings.Default["keySetupRadioButton"] = 2;
                }
                else if (useSliderKeysOnlyRadioButton.Checked)
                {
                    Properties.Settings.Default["keySetupRadioButton"] = 3;
                }
                // Should never be the case
                else
                {
                    Properties.Settings.Default["keySetupRadioButton"] = 0;
                }

                // The checked RadioButton of the 'levelKeysOnlyPanel'
                if (holdLevelLPRadioButton.Checked)
                {
                    Properties.Settings.Default["levelKeysOnlyRadioButton"] = 1;
                }
                else if (holdSliderLPRadioButton.Checked)
                {
                    Properties.Settings.Default["levelKeysOnlyRadioButton"] = 2;
                }
                else if (doNothingLPRadioButton.Checked)
                {
                    Properties.Settings.Default["levelKeysOnlyRadioButton"] = 3;
                }
                // Should never be the case
                else
                {
                    Properties.Settings.Default["levelKeysOnlyRadioButton"] = 0;
                }

                // The value of the 'useHoldDownLevelSystemBPGroupBox.Checked' attribute
                Properties.Settings.Default["useHoldDownBothKeysChecked"] = useHoldDownLevelSystemBPGroupBox.Checked;

                // 'NumericUpDown' values
                Properties.Settings.Default["pressTresholdHoldLevelLPNumericUpDown"] = (int)pressTresholdHoldLevelLPNumericUpDown.Value;
                Properties.Settings.Default["tickIntervalHoldLevelLPNumericUpDown"] = (int)tickIntervalHoldLevelLPNumericUpDown.Value;
                Properties.Settings.Default["pressTresholdHoldSliderLPNumericUpDown"] = (int)pressTresholdHoldSliderLPNumericUpDown.Value;
                Properties.Settings.Default["tickIntervalHoldSliderLPNumericUpDown"] = (int)tickIntervalHoldSliderLPNumericUpDown.Value;
                Properties.Settings.Default["sliderDeltaHoldSliderLPNumericUpDown"] = (int)sliderDeltaHoldSliderLPNumericUpDown.Value;
                Properties.Settings.Default["pressTresholdLevelSystemBPNumericUpDown"] = (int)pressTresholdLevelSystemBPNumericUpDown.Value;
                Properties.Settings.Default["tickIntervalLevelSystemBPNumericUpDown"] = (int)tickIntervalLevelSystemBPNumericUpDown.Value;
                Properties.Settings.Default["tickIntervalSliderSystemBPNumericUpDown"] = (int)tickIntervalSliderSystemBPNumericUpDown.Value;
                Properties.Settings.Default["sliderDeltaSliderSystemBPNumericUpDown"] = (int)sliderDeltaSliderSystemBPNumericUpDown.Value;
                Properties.Settings.Default["tickIntervalSPNumericUpDown"] = (int)tickIntervalSPNumericUpDown.Value;
                Properties.Settings.Default["sliderDeltaSPNumericUpDown"] = (int)sliderDeltaSPNumericUpDown.Value;

                Properties.Settings.Default.Save();
            }
            catch (Exception exc)
            {
                mainForm.Log("Unhandled exception '" + exc + "' thrown while saving!");
            }
        }

        public void LoadSettings()
        {
            mainForm.Log("Loading settings...");

            try
            {
                // Loads key binds
                Keys controlMod = StringToKey((string)Properties.Settings.Default["controlModNextLevelKey"]);
                Keys shiftMod  = StringToKey((string)Properties.Settings.Default["shiftModNextLevelKey"]);
                Keys altMod = StringToKey((string)Properties.Settings.Default["altModNextLevelKey"]);
                Keys key = StringToKey((string)Properties.Settings.Default["nextLevelKey"]);
                mainForm.NextLevelKeyBind.SetKeys(key, controlMod, shiftMod, altMod);

                controlMod = StringToKey((string)Properties.Settings.Default["controlModPrevLevelKey"]);
                shiftMod = StringToKey((string)Properties.Settings.Default["shiftModPrevLevelKey"]);
                altMod = StringToKey((string)Properties.Settings.Default["altModPrevLevelKey"]);
                key = StringToKey((string)Properties.Settings.Default["prevLevelKey"]);
                mainForm.PrevLevelKeyBind.SetKeys(key, controlMod, shiftMod, altMod);

                controlMod = StringToKey((string)Properties.Settings.Default["controlModIncrSliderKey"]);
                shiftMod = StringToKey((string)Properties.Settings.Default["shiftModIncrSliderKey"]);
                altMod = StringToKey((string)Properties.Settings.Default["altModIncrSliderKey"]);
                key = StringToKey((string)Properties.Settings.Default["incrSliderKey"]);
                mainForm.IncrSliderKeyBind.SetKeys(key, controlMod, shiftMod, altMod);

                controlMod = StringToKey((string)Properties.Settings.Default["controlModDecrSliderKey"]);
                shiftMod = StringToKey((string)Properties.Settings.Default["shiftModDecrSliderKey"]);
                altMod = StringToKey((string)Properties.Settings.Default["altModDecrSliderKey"]);
                key = StringToKey((string)Properties.Settings.Default["decrSliderKey"]);
                mainForm.DecrSliderKeyBind.SetKeys(key, controlMod, shiftMod, altMod);

                SyncUIToKeybinds();

                // The checked RadioButton of the 'keySetupGroupBox'
                if ((int)Properties.Settings.Default["keySetupRadioButton"] == 1)
                {
                    useLevelKeysOnlyRadioButton.Checked = true;
                }
                else if ((int)Properties.Settings.Default["keySetupRadioButton"] == 2)
                {
                    useBothKeysRadioButton.Checked = true;
                }
                else if ((int)Properties.Settings.Default["keySetupRadioButton"] == 3)
                {
                    useSliderKeysOnlyRadioButton.Checked = true;
                }
                // Default fallback case if the value of the 'keySetupRadioButton' setting is invalid
                else
                {
                    mainForm.Log("The saved setting 'keySetupRadioButton' has the invalid value '" + Properties.Settings.Default["keySetupRadioButton"] + "'!");
                }

                // The checked RadioButton of the 'levelKeysOnlyPanel'
                if ((int)Properties.Settings.Default["levelKeysOnlyRadioButton"] == 1)
                {
                    holdLevelLPRadioButton.Checked = true;
                }
                else if ((int)Properties.Settings.Default["levelKeysOnlyRadioButton"] == 2)
                {
                    holdSliderLPRadioButton.Checked = true;
                }
                else if ((int)Properties.Settings.Default["levelKeysOnlyRadioButton"] == 3)
                {
                    doNothingLPRadioButton.Checked = true;
                }
                // Default fallback case if the value of the 'levelKeysOnlyRadioButton' setting is invalid
                else
                {
                    mainForm.Log("The saved setting 'levelKeysOnlyRadioButton' has the invalid value '" + Properties.Settings.Default["levelKeysOnlyRadioButton"] + "'!");
                }

                // The value of the 'useHoldDownLevelSystemBPGroupBox.Checked' attribute
                useHoldDownLevelSystemBPGroupBox.Checked = (bool)Properties.Settings.Default["useHoldDownBothKeysChecked"];

                // 'NumericUpDown' values
                int temp = Math.Min((int)pressTresholdHoldLevelLPNumericUpDown.Maximum, (int)Properties.Settings.Default["pressTresholdHoldLevelLPNumericUpDown"]);
                pressTresholdHoldLevelLPNumericUpDown.Value = Math.Max((int)pressTresholdHoldLevelLPNumericUpDown.Minimum, temp);

                temp = Math.Min((int)tickIntervalHoldLevelLPNumericUpDown.Maximum, (int)Properties.Settings.Default["tickIntervalHoldLevelLPNumericUpDown"]);
                tickIntervalHoldLevelLPNumericUpDown.Value = Math.Max((int)tickIntervalHoldLevelLPNumericUpDown.Minimum, temp);

                temp = Math.Min((int)pressTresholdHoldSliderLPNumericUpDown.Maximum, (int)Properties.Settings.Default["pressTresholdHoldSliderLPNumericUpDown"]);
                pressTresholdHoldSliderLPNumericUpDown.Value = Math.Max((int)pressTresholdHoldSliderLPNumericUpDown.Minimum, temp);

                temp = Math.Min((int)tickIntervalHoldSliderLPNumericUpDown.Maximum, (int)Properties.Settings.Default["tickIntervalHoldSliderLPNumericUpDown"]);
                tickIntervalHoldSliderLPNumericUpDown.Value = Math.Max((int)tickIntervalHoldSliderLPNumericUpDown.Minimum, temp);

                temp = Math.Min((int)sliderDeltaHoldSliderLPNumericUpDown.Maximum, (int)Properties.Settings.Default["sliderDeltaHoldSliderLPNumericUpDown"]);
                sliderDeltaHoldSliderLPNumericUpDown.Value = Math.Max((int)sliderDeltaHoldSliderLPNumericUpDown.Minimum, temp);

                temp = Math.Min((int)pressTresholdLevelSystemBPNumericUpDown.Maximum, (int)Properties.Settings.Default["pressTresholdLevelSystemBPNumericUpDown"]);
                pressTresholdLevelSystemBPNumericUpDown.Value = Math.Max((int)pressTresholdLevelSystemBPNumericUpDown.Minimum, temp);

                temp = Math.Min((int)tickIntervalLevelSystemBPNumericUpDown.Maximum, (int)Properties.Settings.Default["tickIntervalLevelSystemBPNumericUpDown"]);
                tickIntervalLevelSystemBPNumericUpDown.Value = Math.Max((int)tickIntervalLevelSystemBPNumericUpDown.Minimum, temp);

                temp = Math.Min((int)tickIntervalSliderSystemBPNumericUpDown.Maximum, (int)Properties.Settings.Default["tickIntervalSliderSystemBPNumericUpDown"]);
                tickIntervalSliderSystemBPNumericUpDown.Value = Math.Max((int)tickIntervalSliderSystemBPNumericUpDown.Minimum, temp);

                temp = Math.Min((int)sliderDeltaSliderSystemBPNumericUpDown.Maximum, (int)Properties.Settings.Default["sliderDeltaSliderSystemBPNumericUpDown"]);
                sliderDeltaSliderSystemBPNumericUpDown.Value = Math.Max((int)sliderDeltaSliderSystemBPNumericUpDown.Minimum, temp);

                temp = Math.Min((int)tickIntervalSPNumericUpDown.Maximum, (int)Properties.Settings.Default["tickIntervalSPNumericUpDown"]);
                tickIntervalSPNumericUpDown.Value = Math.Max((int)tickIntervalSPNumericUpDown.Minimum, temp);

                temp = Math.Min((int)sliderDeltaSPNumericUpDown.Maximum, (int)Properties.Settings.Default["sliderDeltaSPNumericUpDown"]);
                sliderDeltaSPNumericUpDown.Value = Math.Max((int)sliderDeltaSPNumericUpDown.Minimum, temp);
            }
            catch(Exception exc)
            {
                mainForm.Log("Unhandled exception '" + exc +"' thrown while loading!");
            }
        }

        public void RevertSettingsToDefault()
        {
            // Key Binds
            mainForm.NextLevelKeyBind.SetKeys(Keys.ShiftKey, Keys.None, Keys.None, Keys.None);
            mainForm.PrevLevelKeyBind.SetKeys(Keys.ControlKey, Keys.None, Keys.None, Keys.None);
            mainForm.IncrSliderKeyBind.SetKeys(Keys.E, Keys.None, Keys.None, Keys.None);
            mainForm.DecrSliderKeyBind.SetKeys(Keys.Q, Keys.None, Keys.None, Keys.None);
            SyncUIToKeybinds();

            // Key Setup
            useBothKeysRadioButton.Checked = true;
            holdSliderLPRadioButton.Checked = true;
            useHoldDownLevelSystemBPGroupBox.Checked = true;

            // 'NumericUpDown' values
            pressTresholdHoldLevelLPNumericUpDown.Value = 80;
            tickIntervalHoldLevelLPNumericUpDown.Value = 55;
            pressTresholdHoldSliderLPNumericUpDown.Value = 55;
            tickIntervalHoldSliderLPNumericUpDown.Value = 5;
            sliderDeltaHoldSliderLPNumericUpDown.Value = 200;
            pressTresholdLevelSystemBPNumericUpDown.Value = 80;
            tickIntervalLevelSystemBPNumericUpDown.Value = 55;
            tickIntervalSliderSystemBPNumericUpDown.Value = 5;
            sliderDeltaSliderSystemBPNumericUpDown.Value = 200;
            tickIntervalSPNumericUpDown.Value = 5;
            sliderDeltaSPNumericUpDown.Value = 200;
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
            if(currState == SettingsFormState.SettingUp || currState == SettingsFormState.UpdatingKeyBinds) { return; }
            
            // Casts the sender into a ComboBox, this never fails since this method is only added
            // to the events of combo boxes
            ComboBox senderComboBox = (ComboBox)sender;
            mainForm.Log("The key bind of the ComboBox '" + senderComboBox.Name + "' was changed, determing new key-value...");

            // Gets the selected key and casts it into a string
            string newValue = (string)senderComboBox.SelectedItem;
            // Determines the respective Keys value
            Keys newKey = StringToKey(newValue);
            mainForm.Log("Determined key-value '" + newKey + "' from the selected string '" + newValue + "'");

            KeyBind oldKeyBind = null;
        
            // Checks which key bind ComboBox's SelectedIndex changed:

            #region Next Level Key bind
            // Next level comboBox's
            if (senderComboBox.Name == "controlModNextLevelComboBox" || senderComboBox.Name == "shiftModNextLevelComboBox"
                || senderComboBox.Name == "altModNextLevelComboBox" || senderComboBox.Name == "nextLevelComboBox")
            {
                // Stores the key bind before modifying it
                oldKeyBind = new KeyBind(mainForm.NextLevelKeyBind.BoundKey, mainForm.NextLevelKeyBind.ControlMod, mainForm.NextLevelKeyBind.ShiftMod, mainForm.NextLevelKeyBind.AltMod);

                // Modifies the key bind
                if (senderComboBox.Name == "controlModNextLevelComboBox")
                {
                    mainForm.NextLevelKeyBind.ControlMod = newKey;
                }
                else if (senderComboBox.Name == "shiftModNextLevelComboBox")
                {
                    mainForm.NextLevelKeyBind.ShiftMod = newKey;
                }
                else if (senderComboBox.Name == "altModNextLevelComboBox")
                {
                    mainForm.NextLevelKeyBind.AltMod = newKey;
                }
                else if (senderComboBox.Name == "nextLevelComboBox")
                {
                    mainForm.NextLevelKeyBind.BoundKey = newKey;
                }

                // Checks if another key is already bound to that key and swaps the keys
                if (mainForm.PrevLevelKeyBind.Equals(mainForm.NextLevelKeyBind))
                {
                    mainForm.PrevLevelKeyBind = oldKeyBind;
                }
                if (mainForm.IncrSliderKeyBind.Equals(mainForm.NextLevelKeyBind))
                {
                    mainForm.IncrSliderKeyBind = oldKeyBind;
                }
                if (mainForm.DecrSliderKeyBind.Equals(mainForm.NextLevelKeyBind))
                {
                    mainForm.DecrSliderKeyBind = oldKeyBind;
                }
            }
            #endregion

            #region Previous Level Key bind
            // Previous level comboBox's
            if (senderComboBox.Name == "controlModPrevLevelComboBox" || senderComboBox.Name == "shiftModPrevLevelComboBox"
                || senderComboBox.Name == "altModPrevLevelComboBox" || senderComboBox.Name == "prevLevelComboBox")
            {
                // Stores the key bind before modifying it
                oldKeyBind = new KeyBind(mainForm.PrevLevelKeyBind.BoundKey, mainForm.PrevLevelKeyBind.ControlMod, mainForm.PrevLevelKeyBind.ShiftMod, mainForm.PrevLevelKeyBind.AltMod);

                // Modifies the key bind
                if (senderComboBox.Name == "controlModPrevLevelComboBox")
                {
                    mainForm.PrevLevelKeyBind.ControlMod = newKey;
                }
                else if (senderComboBox.Name == "shiftModPrevLevelComboBox")
                {
                    mainForm.PrevLevelKeyBind.ShiftMod = newKey;
                }
                else if (senderComboBox.Name == "altModPrevLevelComboBox")
                {
                    mainForm.PrevLevelKeyBind.AltMod = newKey;
                }
                else if (senderComboBox.Name == "prevLevelComboBox")
                {
                    mainForm.PrevLevelKeyBind.BoundKey = newKey;
                }

                // Checks if another key is already bound to that key and swaps the keys
                if (mainForm.NextLevelKeyBind.Equals(mainForm.PrevLevelKeyBind))
                {
                    mainForm.NextLevelKeyBind = oldKeyBind;
                }
                if (mainForm.IncrSliderKeyBind.Equals(mainForm.PrevLevelKeyBind))
                {
                    mainForm.IncrSliderKeyBind = oldKeyBind;
                }
                if (mainForm.DecrSliderKeyBind.Equals(mainForm.PrevLevelKeyBind))
                {
                    mainForm.DecrSliderKeyBind = oldKeyBind;
                }
            }
            #endregion

            #region Increase Slider Key Bind
            if (senderComboBox.Name == "controlModIncrSliderComboBox" || senderComboBox.Name == "shiftModIncrSliderComboBox"
                || senderComboBox.Name == "altModIncrSliderComboBox" || senderComboBox.Name == "incrSliderComboBox")
            {
                // Stores the key bind before modifying it
                oldKeyBind = new KeyBind(mainForm.IncrSliderKeyBind.BoundKey, mainForm.IncrSliderKeyBind.ControlMod, mainForm.IncrSliderKeyBind.ShiftMod, mainForm.IncrSliderKeyBind.AltMod);

                // Modifies the key bind
                if (senderComboBox.Name == "controlModIncrSliderComboBox")
                {
                    mainForm.IncrSliderKeyBind.ControlMod = newKey;
                }
                else if (senderComboBox.Name == "shiftModIncrSliderComboBox")
                {
                    mainForm.IncrSliderKeyBind.ShiftMod = newKey;
                }
                else if (senderComboBox.Name == "altModIncrSliderComboBox")
                {
                    mainForm.IncrSliderKeyBind.AltMod = newKey;
                }
                else if (senderComboBox.Name == "incrSliderComboBox")
                {
                    mainForm.IncrSliderKeyBind.BoundKey = newKey;
                }
                
                // Checks if another key is already bound to that key and swaps the keys
                if (mainForm.NextLevelKeyBind.Equals(mainForm.IncrSliderKeyBind))
                {
                    mainForm.NextLevelKeyBind = oldKeyBind;
                }
                if (mainForm.PrevLevelKeyBind.Equals(mainForm.IncrSliderKeyBind))
                {
                    mainForm.PrevLevelKeyBind = oldKeyBind;
                }
                if (mainForm.DecrSliderKeyBind.Equals(mainForm.IncrSliderKeyBind))
                {
                    mainForm.DecrSliderKeyBind = oldKeyBind;
                }
            }
            #endregion

            #region Decrease Slider Key Bind
            if (senderComboBox.Name == "controlModDecrSliderComboBox" || senderComboBox.Name == "shiftModDecrSliderComboBox"
                || senderComboBox.Name == "altModDecrSliderComboBox" || senderComboBox.Name == "decrSliderComboBox")
            {
                // Stores the key bind before modifying it
                oldKeyBind = new KeyBind(mainForm.DecrSliderKeyBind.BoundKey, mainForm.DecrSliderKeyBind.ControlMod, mainForm.DecrSliderKeyBind.ShiftMod, mainForm.DecrSliderKeyBind.AltMod);

                // Modifies the key bind
                if (senderComboBox.Name == "controlModDecrSliderComboBox")
                {
                    mainForm.DecrSliderKeyBind.ControlMod = newKey;
                }
                else if (senderComboBox.Name == "shiftModDecrSliderComboBox")
                {
                    mainForm.DecrSliderKeyBind.ShiftMod = newKey;
                }
                else if (senderComboBox.Name == "altModDecrSliderComboBox")
                {
                    mainForm.DecrSliderKeyBind.AltMod = newKey;
                }
                else if (senderComboBox.Name == "decrSliderComboBox")
                {
                    mainForm.DecrSliderKeyBind.BoundKey = newKey;
                }

                // Checks if the new key bind is a duplicate
                if (mainForm.NextLevelKeyBind.Equals(mainForm.DecrSliderKeyBind))
                {
                    mainForm.NextLevelKeyBind = oldKeyBind;
                }
                if (mainForm.PrevLevelKeyBind.Equals(mainForm.DecrSliderKeyBind))
                {
                    mainForm.PrevLevelKeyBind = oldKeyBind;
                }
                if (mainForm.IncrSliderKeyBind.Equals(mainForm.DecrSliderKeyBind))
                {
                    mainForm.IncrSliderKeyBind = oldKeyBind;
                }

            }
            #endregion

            SyncUIToKeybinds();
        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            SaveCurrSettings();
        }

        private void revertChangesButton_Click(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void revertToDefaultButton_Click(object sender, EventArgs e)
        {
            RevertSettingsToDefault();
        }

        #endregion
    }

    public enum KeyHoldDownMode { None, Level, Slider };
    public enum SettingsFormState { SettingUp, Idle, UpdatingForm, UpdatingKeyBinds};
}