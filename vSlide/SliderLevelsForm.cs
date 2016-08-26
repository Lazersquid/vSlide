using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace vSlide
{
    public partial class SliderLevelsForm : Form
    {
        #region Fields

        MainForm mainForm;
        int NumberOfSliderLevels
        {
            get { return sliderLevelControlList.Count; }
        }

        // Saves all SliderLevelControl's
        List<SliderLevelControl> sliderLevelControlList = new List<SliderLevelControl>();

        #endregion

        public SliderLevelsForm(MainForm mainForm, int numberOfLevels)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            
            numberOfLevelsNumericUpDown.Value = numberOfLevels;
            SyncCountOfSliderLevelsToLevelNumber(numberOfLevels);

            SetValuesOfLevelsEqualy();
            
            // Subscribes to the newJoystickAcquired event to update the 'maxAbsoluteSliderValue' of the slider levels
            // to the new maxSliderValue of the new device
            mainForm.NewJoystickAcquired += UpdateMaxSliderValueOfSliderLevelControls;
        }

        #region Methods

        private void SyncCountOfSliderLevelsToLevelNumber(int numberOfLevels)
        {
            // Gets the difference of the current number of Levels (NumberOfLevels) and the target number (numberOfLevels)
            int delta = numberOfLevels - NumberOfSliderLevels;

            // Creates the needed amount of SliderLevelControls if delta is positive
            if (delta > 0)
            {
                for (; delta > 0; delta--)
                {
                    CreateNewSliderLevelControl();
                }
            }

            // Deletes SliderLevelControls if delta is negative
            else if (delta < 0)
            {
                for (; delta < 0; delta++)
                {
                    DeleteLastSliderLevelControl();
                }
            }
        }

        private void CreateNewSliderLevelControl()
        {
            int sliderLevelIndex = sliderLevelControlList.Count;
            mainForm.Log("Creating slider level '" + (sliderLevelIndex+1) + "'...");

            // Creates a new SliderLevelControl and adds it to the sliderLevelControlList
            SliderLevelControl newLevelControl = new SliderLevelControl(sliderLevelIndex, sliderLevelsFlowLayoutPanel, (int)mainForm.MaxSliderValue);
            sliderLevelControlList.Add(newLevelControl);

            // Subscribes to the value changed event of the control
            newLevelControl.SliderLevelRelativeNumericUpDown_ValueChanged += SliderLevelRelativeNumericUpDown_ValueChanged;

            // Sets the value of the SliderLevelControl to the max value of the slider
            newLevelControl.RelativeValue = 100;
        }

        private void DeleteLastSliderLevelControl()
        {
            if(NumberOfSliderLevels < 0 )
            {
                mainForm.Log("Tried to delete a SliderLevelControl while there were none, returning...");
                return;
            }

            mainForm.Log("Removing slider level '" + (sliderLevelControlList.Count) + "'...");
            // Creates the last SliderLevelControl and removes it from the sliderLevelControlList
            SliderLevelControl sliderLevelControlToRemove = sliderLevelControlList[sliderLevelControlList.Count - 1];
            sliderLevelControlList.RemoveAt(sliderLevelControlList.Count - 1);

            // Unsubscribes from the value changed event of the control
            sliderLevelControlToRemove.SliderLevelRelativeNumericUpDown_ValueChanged -= SliderLevelRelativeNumericUpDown_ValueChanged;

            sliderLevelControlToRemove.Remove();
        }

        private void SetValuesOfLevelsEqualy()
        {
            // Insures that the NumberOfLevels is between 0 and 100
            if (NumberOfSliderLevels < 2 || NumberOfSliderLevels > 100)
            {
                mainForm.Log("There is an illegal amount of levels '" + NumberOfSliderLevels + "', returning...");
                return;
            }

            decimal stepValueRel = 1m / (NumberOfSliderLevels - 1);

            // Iterates through all SliderLevelControl's and sets their relative value
            for (int i = 0; i < NumberOfSliderLevels; i++)
            {
                sliderLevelControlList[i].RelativeValue = (stepValueRel * i) * 100;
            }
        }

        private void CheckNewSliderLevelRelativeValue(int sliderLevel, SliderLevelControl control)
        {
            // Ensures that the relaitve-value of a level is alwys lower than the relative value of the next level
            if (sliderLevel + 1 < NumberOfSliderLevels && control.RelativeValue >= sliderLevelControlList[sliderLevel + 1].RelativeValue)
            {
                mainForm.Log("Tried to set the relative value of level '" + (sliderLevel + 1) + "' to '" + control.RelativeValue +
                    "'. But the relative value of level '" + (sliderLevel + 2) + "' is '" + sliderLevelControlList[sliderLevel + 1].RelativeValue + "'");
                control.RelativeValue = sliderLevelControlList[sliderLevel + 1].RelativeValue - 1;
            }

            // Ensures that the relative-value of a level is alwys higher than the relative value of the previous level
            if (sliderLevel > 0 && control.RelativeValue <= sliderLevelControlList[sliderLevel - 1].RelativeValue)
            {
                mainForm.Log("Tried to set the absolute value of level '" + (sliderLevel + 1) + "' to '" + control.RelativeValue +
                    "'. But the absolute value of level '" + (sliderLevel) + "' is '" + sliderLevelControlList[sliderLevel - 1].RelativeValue + "'");
                control.RelativeValue = sliderLevelControlList[sliderLevel - 1].RelativeValue + 1;
            }
        }

        public int GetSliderValueOfTheNextLevel(int currSliderValue)
        {
            // Checks if the sliderValue is already as high/higher than the absoluteValue of the highest-level
            if (currSliderValue >= sliderLevelControlList[NumberOfSliderLevels-1].AbsoluteValue)
            {
                mainForm.Log("The slider value is equal or higher than the highest-level's value");
                return currSliderValue;
            }

            // Iterates through all levels, beginning with the lowest until the absolute value of a level is higher than
            // 'sliderValue' then returns the absolute value of that level

            for (int i = 0; i < NumberOfSliderLevels; i++)
            {
                if (sliderLevelControlList[i].AbsoluteValue > currSliderValue)
                {
                    mainForm.Log("Setting slider value to Level '" + (i+1) + "'");
                    return sliderLevelControlList[i].AbsoluteValue;
                }
            }

            // Fallback case that should never run
            mainForm.Log("Found no level to set the slider to!");
            return currSliderValue;
        }

        public int GetSliderValueOfThePreviousLevel(int currSliderValue)
        {
            // Checks if the sliderValue is already as low/lower than the absoluteValue of the lowest-level
            if (currSliderValue <= sliderLevelControlList[0].AbsoluteValue)
            {
                mainForm.Log("The slider value is equal or smaller than the lowest-level's value");
                return currSliderValue;
            }

            // Iterates through all levels, beginning with the highest until the absolute value of a level is lower than
            // 'sliderValue' then returns the absolute value of that level
            for (int i = NumberOfSliderLevels-1; i >= 0; i--)
            {
                if (sliderLevelControlList[i].AbsoluteValue < currSliderValue)
                {
                    mainForm.Log("Setting slider value to Level '" + (i+1) + "'");
                    return sliderLevelControlList[i].AbsoluteValue;
                }
            }

            // Fallback case that should never run
            mainForm.Log("Found no level to set the slider to!");
            return currSliderValue;
        }
        
        public void UpdateMaxSliderValueOfSliderLevelControls(uint newJoystickId, int newMax)
        {
            // Updates 'MaxAbsoluteSliderValue' variable of every SliderLevelControl
            foreach (SliderLevelControl sliderLevel in sliderLevelControlList)
            {
                sliderLevel.MaxAbsoluteSliderValue = newMax;
            }
        }
        
        public void SaveSliderLevels()
        {
            mainForm.Log("Saving slider levels...");

            // Adds all sliderLevels absolute values to an array
            int[] sliderLevelsAbsoluteArray = new int[NumberOfSliderLevels];
            for (int i = 0; i < NumberOfSliderLevels; i++)
            {
                sliderLevelsAbsoluteArray[i] = sliderLevelControlList[i].AbsoluteValue;
            }

            // Adds all sliderLevels relative values to an array
            decimal[] sliderLevelsRelativeArray = new decimal[NumberOfSliderLevels];
            for (int i = 0; i < NumberOfSliderLevels; i++)
            {
                sliderLevelsRelativeArray[i] = sliderLevelControlList[i].RelativeValue;
            }

            // Converts the arrays that store the values of the slider levels to a string, seperating values with a ';'
            Properties.Settings.Default["sliderLevelsAbsolute"] = String.Join(";", sliderLevelsAbsoluteArray.Select(i => i.ToString()).ToArray());
            Properties.Settings.Default["sliderLevelsRelative"] = String.Join(";", sliderLevelsRelativeArray.Select(i => i.ToString()).ToArray());
            Properties.Settings.Default.Save();
        }
        
        public void LoadSliderLevels()
        {
            mainForm.Log("Loading slider levels...");

            // Converts the saved relative values of the slider levels from a string to an int array.
            // The slider values are saved in the 'sliderLevelsRelative' setting as a string, where all valus are seperated by a ';'
            decimal[] sliderLevelsRelativeArray;
            try
            {
                sliderLevelsRelativeArray = ((string)Properties.Settings.Default["sliderLevelsRelative"]).Split(';').Select(s => Decimal.Parse(s)).ToArray();
            }
            catch (Exception exc)
            {
                mainForm.Log("Unhandlex exception '" + exc +"' was thrown while loading slider levels!");
                return;
            }
            
            // Sets the number of slider levels and their relative values
            numberOfLevelsNumericUpDown.Value = sliderLevelsRelativeArray.Length;
            for (int i = 0; i < sliderLevelsRelativeArray.Length; i++)
            {
                // Ensures that only values between 0 and 100 are loaded
                if (sliderLevelsRelativeArray[i] < 0 || sliderLevelsRelativeArray[i] > 100) continue;
                sliderLevelControlList[i].RelativeValue = sliderLevelsRelativeArray[i];
            }
        }

        #endregion

        #region Event Methods

        private void SliderLevelsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Hides the form instead of closing it
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void numberOfLevelsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SyncCountOfSliderLevelsToLevelNumber((int)numberOfLevelsNumericUpDown.Value);
        }

        private void setValuesEqualyButton_Click(object sender, EventArgs e)
        {
            SetValuesOfLevelsEqualy();
        }

        private void saveSliderLevelsButton_Click(object sender, EventArgs e)
        {
            SaveSliderLevels();
        }

        private void revertSliderLevelsButton_Click(object sender, EventArgs e)
        {
            LoadSliderLevels();
        }

        private void revertSliderLevelToDefaultButton_Click(object sender, EventArgs e)
        {
            numberOfLevelsNumericUpDown.Value = 7;
            SetValuesOfLevelsEqualy();
        }
        private void SliderLevelRelativeNumericUpDown_ValueChanged(int sliderLevel, SliderLevelControl control)
        {
            CheckNewSliderLevelRelativeValue(sliderLevel, control);
            mainForm.Log("The relative value of level '" + (sliderLevel + 1) + "' was changed to '" + control.RelativeNumericUpDownValue + "'");
        }

        #endregion
    }

    public class SliderLevelControl
    {
        #region Fields

        // Stores the slider level index of the control
        int sliderLevel;
        // Stores the maximum value of the slider
        int maxAbsoluteSliderValue;
        public int MaxAbsoluteSliderValue
        {
            get { return maxAbsoluteSliderValue; }
            set
            {
                // Ensures that the 'maxAbsoluteSliderValue' is higher than 0
                maxAbsoluteSliderValue = Math.Max(1, value);
            }
        }
        // Stores the GroupBox control
        GroupBox groupbox;

        // Used to temporarily ignore events
        bool ignoreEvents = false;

        // Variables related to the absoluteValue
        int absoluteValue;
        public int AbsoluteValue
        {
            get { return absoluteValue; }
        }

        // Variables related to the relativeValue
        decimal relativeValue;
        public decimal RelativeValue
        {
            get { return relativeValue; }
            set
            {
                // Insures that value is between 0 and 100
                value = Math.Max(value, 0);
                value = Math.Min(value, 100);

                // Makes this control ignore events until all controls of this control
                // have been modified
                ignoreEvents = true;

                relativeValue = value;
                relativeNumericUpDown.Value = value;

                absoluteValue = (int)(maxAbsoluteSliderValue * (relativeValue / 100));

                // Disables event ignoring
                ignoreEvents = false;
            }
        }
        Label relativeValueInfoLabel;
        NumericUpDown relativeNumericUpDown;
        Label percentValueInfoLabel;
        public int RelativeNumericUpDownValue
        {
            get { return (int)relativeNumericUpDown.Value; }
        }

        #endregion

        public delegate void SliderLevelControlEventHandler(int sliderLevel, SliderLevelControl control);
        public event SliderLevelControlEventHandler SliderLevelRelativeNumericUpDown_ValueChanged;

        public SliderLevelControl(int sliderLevel, Control parent, int maxSliderValue)
        {
            // Saves the slider level index of this control and the maximum value oft he slider
            this.sliderLevel = sliderLevel;
            maxAbsoluteSliderValue = maxSliderValue;

            // Creates a GroupBox that stores all controls of the SliderLevelControl
            groupbox = new GroupBox();
            groupbox.Size = new Size(192, 48);
            groupbox.Text = "Level " + (sliderLevel + 1);

            //Creates an information label (has no advanced functionality)
            relativeValueInfoLabel = new Label();
            relativeValueInfoLabel.AutoSize = true;
            relativeValueInfoLabel.Location = new Point(12, 21);
            relativeValueInfoLabel.Text = "Value:";
            groupbox.Controls.Add(relativeValueInfoLabel);

            //Creates an information label (has no advanced functionality)
            percentValueInfoLabel = new Label();
            percentValueInfoLabel.AutoSize = true;
            percentValueInfoLabel.Location = new Point(114, 23);
            percentValueInfoLabel.Text = "%";
            groupbox.Controls.Add(percentValueInfoLabel);

            //Creates a NumericUpDown that lets the user set the relative value of the SliderLevelControl
            relativeNumericUpDown = new NumericUpDown();
            relativeNumericUpDown.DecimalPlaces = 2;
            relativeNumericUpDown.Increment = 0.5m;
            relativeNumericUpDown.Maximum = 100;
            relativeNumericUpDown.Minimum = 0;
            relativeNumericUpDown.Location = new Point(55, 19);
            relativeNumericUpDown.Size = new Size(59, 20);
            groupbox.Controls.Add(relativeNumericUpDown);

            //Subscribes to the NumericUpDown's ValueChanged event
            relativeNumericUpDown.ValueChanged += RelativeNumericUpDown_ValueChanged;

            parent.Controls.Add(groupbox);
        }

        /// <summary>
        /// Removes all controls and unsubscribes off all events. Make sure that no method is subscribed to the events of the control you are removing!
        /// </summary>
        public void Remove()
        {
            relativeNumericUpDown.ValueChanged -= RelativeNumericUpDown_ValueChanged;
            
            groupbox.Controls.Remove(relativeValueInfoLabel);
            groupbox.Controls.Remove(percentValueInfoLabel);
            groupbox.Controls.Remove(relativeNumericUpDown);
            groupbox.Parent.Controls.Remove(groupbox);
        }
        
        private void RelativeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            // Ignores the event
            if (ignoreEvents) return;

            RelativeValue = relativeNumericUpDown.Value;
            // Invokes the event
            if (SliderLevelRelativeNumericUpDown_ValueChanged != null)
            {
                SliderLevelRelativeNumericUpDown_ValueChanged(sliderLevel, this);
            }
        }
    }
}
