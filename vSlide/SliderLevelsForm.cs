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

            // Subscribes to the value changed events of the control
            newLevelControl.SliderLevelAbsoluteNumericUpDown_ValueChanged += SliderLevelAbsoluteNumericUpDown_ValueChanged;
            newLevelControl.SliderLevelRelativeNumericUpDown_ValueChanged += SliderLevelRelativeNumericUpDown_ValueChanged;

            // Sets the value of the SliderLevelControl to the max value of the slider
            newLevelControl.AbsoluteValue = mainForm.MaxSliderValue;
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

            // Unsubscribes from the value changed events of the control
            sliderLevelControlToRemove.SliderLevelAbsoluteNumericUpDown_ValueChanged -= SliderLevelAbsoluteNumericUpDown_ValueChanged;
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

            float stepValueRel = 1f / (NumberOfSliderLevels - 1);

            // Iterates through all SliderLevelControl's and sets their absolute value
            for (int i = 0; i < NumberOfSliderLevels; i++)
            {
                sliderLevelControlList[i].AbsoluteValue = (int)(mainForm.MaxSliderValue * (stepValueRel * i));
            }
        }

        private void CheckNewSliderLevelAbsoluteValue(int sliderLevel, SliderLevelControl control)
        {
            // Ensures that the absolute-value of a level is alwys lower than the absolue value of the next level
            if (sliderLevel + 1 < NumberOfSliderLevels && control.AbsoluteValue >= sliderLevelControlList[sliderLevel + 1].AbsoluteValue)
            {
                mainForm.Log("Tried to set the absolute value of level '" + (sliderLevel + 1) + "' to '" + control.AbsoluteValue +
                    "'. But the absolute value of level '" + (sliderLevel + 2) + "' is '" + sliderLevelControlList[sliderLevel + 1].AbsoluteValue + "'");
                control.AbsoluteValue = sliderLevelControlList[sliderLevel + 1].AbsoluteValue - 1;
            }

            // Ensures that the absolute-value of a level is alwys higher than the absolue value of the previous level
            if (sliderLevel > 0 && control.AbsoluteValue <= sliderLevelControlList[sliderLevel - 1].AbsoluteValue)
            {
                mainForm.Log("Tried to set the absolute value of level '" + (sliderLevel + 1) + "' to '" + control.AbsoluteValue +
                    "'. But the absolute value of level '" + (sliderLevel) + "' is '" + sliderLevelControlList[sliderLevel - 1].AbsoluteValue + "'");
                control.AbsoluteValue = sliderLevelControlList[sliderLevel - 1].AbsoluteValue + 1;
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
            int[] sliderLevelsArray = new int[NumberOfSliderLevels];
            for (int i = 0; i < NumberOfSliderLevels; i++)
            {
                sliderLevelsArray[i] = sliderLevelControlList[i].AbsoluteValue;
            }

            // Converts the array that stores the absolute values of the slider values to a string, seperating values with a ','
            Properties.Settings.Default["sliderLevels"] = String.Join(",", sliderLevelsArray.Select(i => i.ToString()).ToArray());
            Properties.Settings.Default.Save();
        }

        public void LoadSliderLevels()
        {
            mainForm.Log("Loading slider levels...");

            int[] sliderLevelsArray;
            try
            {
                sliderLevelsArray = ((string)Properties.Settings.Default["sliderLevels"]).Split(',').Select(s => Int32.Parse(s)).ToArray();
            }
            catch (Exception exc)
            {
                mainForm.Log("Unhandlex exception '" + exc +"' was thrown while loading slider levels!");
                return;
            }
            
            // 
            numberOfLevelsNumericUpDown.Value = sliderLevelsArray.Length;
            for (int i = 0; i < sliderLevelsArray.Length; i++)
            {
                sliderLevelControlList[i].AbsoluteValue = sliderLevelsArray[i];
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

        private void SliderLevelAbsoluteNumericUpDown_ValueChanged(int sliderLevel, SliderLevelControl control)
        {
            CheckNewSliderLevelAbsoluteValue(sliderLevel, control);
            mainForm.Log("The absolute value of level '" + (sliderLevel + 1) + "' was changed to '" + control.AbsoluteValue + "'");
        }
        private void SliderLevelRelativeNumericUpDown_ValueChanged(int sliderLevel, SliderLevelControl control)
        {
            CheckNewSliderLevelAbsoluteValue(sliderLevel, control);
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

                // Updates the maximum variable of the 'absoluteNumericUpDown'
                absoluteNumericUpDown.Maximum = maxAbsoluteSliderValue;
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
            set
            {
                // Insures that value is between 0 and 'maxAbsoluteSliderValue'
                value = Math.Max(value, 0);
                value = Math.Min(value, maxAbsoluteSliderValue);

                // Makes this control ignore events until all controls of this control
                // have been modified
                ignoreEvents = true;

                absoluteValue = value;
                absoluteValueLabel.Text = value.ToString();
                absoluteNumericUpDown.Value = value;

                decimal newRelative = Math.Max(0, (int)((value / (decimal)maxAbsoluteSliderValue) * 100));
                newRelative = Math.Min(100, newRelative);

                relativeValue = (int)newRelative;
                relativeValueLabel.Text = relativeValue + "%";
                relativeNumericUpDown.Value = relativeValue;

                // Disables event ignoring
                ignoreEvents = false;

            }
        }
        Label absoluteValueInfoLabel;
        Label absoluteValueLabel;
        NumericUpDown absoluteNumericUpDown;
        public int AbsoluteNumericUpDownValue
        {
            get { return (int)absoluteNumericUpDown.Value; }
        }

        // Variables related to the relativeValue
        int relativeValue;
        public int RelativeValue
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
                relativeValueLabel.Text = value + "%";
                relativeNumericUpDown.Value = value;

                absoluteValue = (int)(maxAbsoluteSliderValue * (relativeValue / 100f));
                absoluteValueLabel.Text = absoluteValue.ToString();
                absoluteNumericUpDown.Value = absoluteValue;

                // Disables event ignoring
                ignoreEvents = false;
            }
        }
        Label relativeValueInfoLabel;
        Label relativeValueLabel;
        NumericUpDown relativeNumericUpDown;
        public int RelativeNumericUpDownValue
        {
            get { return (int)relativeNumericUpDown.Value; }
        }

        #endregion

        public delegate void SliderLevelControlEventHandler(int sliderLevel, SliderLevelControl control);
        public event SliderLevelControlEventHandler SliderLevelAbsoluteNumericUpDown_ValueChanged;
        public event SliderLevelControlEventHandler SliderLevelRelativeNumericUpDown_ValueChanged;

        public SliderLevelControl(int sliderLevel, Control parent, int maxSliderValue)
        {
            // Saves the slider level index of this control and the maximum value oft he slider
            this.sliderLevel = sliderLevel;
            maxAbsoluteSliderValue = maxSliderValue;

            // Creates a GroupBox that stores all controls of the SliderLevelControl
            groupbox = new GroupBox();
            groupbox.Size = new Size(295, 68);
            groupbox.Text = "Level " + (sliderLevel + 1);

            //Creates an information label (has no advanced functionality)
            absoluteValueInfoLabel = new Label();
            absoluteValueInfoLabel.AutoSize = true;
            absoluteValueInfoLabel.Location = new Point(8, 18);
            absoluteValueInfoLabel.Text = "Absolute Value:";
            groupbox.Controls.Add(absoluteValueInfoLabel);

            //Creates a label that displays the absolute value of the SliderLevelControl
            absoluteValueLabel = new Label();
            absoluteValueLabel.AutoSize = true;
            absoluteValueLabel.Location = new Point(95, 18);
            absoluteValueLabel.Text = "-";
            groupbox.Controls.Add(absoluteValueLabel);

            //Creates a NumericUpDown that lets the user set the absolute value of the SliderLevelControl
            absoluteNumericUpDown = new NumericUpDown();
            absoluteNumericUpDown.Maximum = maxAbsoluteSliderValue;
            absoluteNumericUpDown.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            absoluteNumericUpDown.Location = new Point(200, 16);
            absoluteNumericUpDown.Size = new Size(84, 20);
            groupbox.Controls.Add(absoluteNumericUpDown);

            //Subscribes to the NumericUpDown's ValueChanged event
            absoluteNumericUpDown.ValueChanged += AbsoluteNumericUpDown_ValueChanged;

            //Creates an information label (has no advanced functionality)
            relativeValueInfoLabel = new Label();
            relativeValueInfoLabel.AutoSize = true;
            relativeValueInfoLabel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            relativeValueInfoLabel.Location = new Point(8, 42);
            relativeValueInfoLabel.Text = "Relative Value:";
            groupbox.Controls.Add(relativeValueInfoLabel);

            //Creates a label that displays the relative value of the SliderLevelControl
            relativeValueLabel = new Label();
            relativeValueLabel.AutoSize = true;
            relativeValueLabel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            relativeValueLabel.Location = new Point(95, 42);
            relativeValueLabel.Text = "-";
            groupbox.Controls.Add(relativeValueLabel);

            //Creates a NumericUpDown that lets the user set the relative value of the SliderLevelControl
            relativeNumericUpDown = new NumericUpDown();
            relativeNumericUpDown.Maximum = 100;
            relativeNumericUpDown.Minimum = 0;
            relativeNumericUpDown.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            relativeNumericUpDown.Location = new Point(200, 42);
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
            absoluteNumericUpDown.ValueChanged -= AbsoluteNumericUpDown_ValueChanged;
            relativeNumericUpDown.ValueChanged -= RelativeNumericUpDown_ValueChanged;

            groupbox.Controls.Remove(absoluteValueInfoLabel);
            groupbox.Controls.Remove(absoluteValueLabel);
            groupbox.Controls.Remove(absoluteNumericUpDown);
            groupbox.Controls.Remove(relativeValueInfoLabel);
            groupbox.Controls.Remove(relativeValueLabel);
            groupbox.Controls.Remove(relativeNumericUpDown);
            groupbox.Parent.Controls.Remove(groupbox);
        }

        private void AbsoluteNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            // Ignores the event
            if (ignoreEvents) return;

            AbsoluteValue = (int)absoluteNumericUpDown.Value;

            // Invokes the event
            if(SliderLevelAbsoluteNumericUpDown_ValueChanged != null)
            {
                SliderLevelAbsoluteNumericUpDown_ValueChanged(sliderLevel, this);
            }
        }
        private void RelativeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            // Ignores the event
            if (ignoreEvents) return;

            RelativeValue = (int)relativeNumericUpDown.Value;
            // Invokes the event
            if (SliderLevelRelativeNumericUpDown_ValueChanged != null)
            {
                SliderLevelRelativeNumericUpDown_ValueChanged(sliderLevel, this);
            }
        }
    }
}
