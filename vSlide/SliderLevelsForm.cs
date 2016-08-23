using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace vSlide
{
    public partial class SliderLevelsForm : Form
    {
        #region Fields

        MainForm mainForm;
        int NumberOfLevels
        {
            get { return mappingLevelControlList.Count; }
        }

        // Saves all MappingLevelControl's
        List<MappingLevelControl> mappingLevelControlList = new List<MappingLevelControl>();

        #endregion

        public SliderLevelsForm(MainForm mainForm, int numberOfLevels)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            
            // Creates as many mappingLevelGroupBoxes as 'numberOfLevels' specefies
            numberOfLevelsNumericUpDown.Value = numberOfLevels;
            SyncMappingThemeFlowLayoutPanelToLevelNumber(numberOfLevels);

            SetValuesOfLevelsEqualy();
            
            // Subscribes to the newJoystickAcquired event to update the 'maxAbsoluteSliderValue' of the mapping levels
            // to the new maxSliderValue of the new device
            mainForm.NewJoystickAcquired += UpdateMaxSliderValueOfMappingLevelControls;
        }

        #region Methods

        private void SyncMappingThemeFlowLayoutPanelToLevelNumber(int numberOfLevels)
        {
            // Gets the difference of the current number of Levels (NumberOfLevels) and the target number (numberOfLevels)
            int delta = numberOfLevels - NumberOfLevels;

            // Creates the needed amount of mapping level controls if delta is positive
            if(delta > 0)
            {
                for (; delta > 0; delta--)
                {
                    CreateNewMappingLevelControl();
                }
            }

            // Deletes mapping level controls if delta is negative
            else if (delta < 0)
            {
                for (; delta < 0; delta++)
                {
                    DeleteLastMappingLevelControl();
                }
            }
        }

        private void CreateNewMappingLevelControl()
        {
            int mappingLevelIndex = mappingLevelControlList.Count;
            mainForm.Log("Creating mapping level '" + (mappingLevelIndex+1) + "'...");

            // Creates a new MappingLevelControl and adds it to the mappingLevelList
            MappingLevelControl newLevelControl = new MappingLevelControl(mappingLevelIndex, mappingThemeFlowLayoutPanel, (int)mainForm.MaxSliderValue);
            mappingLevelControlList.Add(newLevelControl);

            // Subscribes to the value changed events of the control
            newLevelControl.MappingLevelAbsoluteNumericUpDown_ValueChanged += MappingLevelAbsoluteNumericUpDown_ValueChanged;
            newLevelControl.MappingLevelRelativeNumericUpDown_ValueChanged += MappingLevelRelativeNumericUpDown_ValueChanged;

            // Sets the value of the MappingLevelControl to the max value of the slider
            newLevelControl.AbsoluteValue = mainForm.MaxSliderValue;
        }

        private void DeleteLastMappingLevelControl()
        {
            if(NumberOfLevels < 0 )
            {
                mainForm.Log("Tried to delete a mapping level control while there were none, returning...");
                return;
            }

            mainForm.Log("Removing mapping level '" + (mappingLevelControlList.Count) + "'...");
            // Creates the last MappingLevelControl and removes it from the mappingLevelList
            MappingLevelControl mappingLevelToRemove = mappingLevelControlList[mappingLevelControlList.Count - 1];
            mappingLevelControlList.RemoveAt(mappingLevelControlList.Count - 1);

            // Unsubscribes from the value changed events of the control
            mappingLevelToRemove.MappingLevelAbsoluteNumericUpDown_ValueChanged -= MappingLevelAbsoluteNumericUpDown_ValueChanged;
            mappingLevelToRemove.MappingLevelRelativeNumericUpDown_ValueChanged -= MappingLevelRelativeNumericUpDown_ValueChanged;

            mappingLevelToRemove.Remove();
        }

        private void SetValuesOfLevelsEqualy()
        {
            // Insures that the NumberOfLevels is between 0 and 100
            if (NumberOfLevels < 2 || NumberOfLevels > 100)
            {
                mainForm.Log("There is an illegal amount of levels '" + NumberOfLevels + "', returning...");
                return;
            }

            float stepValueRel = 1f / (NumberOfLevels - 1);

            // Iterates through all MappingLevelControl's and sets their absolute value
            for (int i = 0; i < NumberOfLevels; i++)
            {
                mappingLevelControlList[i].AbsoluteValue = (int)(mainForm.MaxSliderValue * (stepValueRel * i));
            }
        }

        private void CheckNewMappingLevelAbsoluteValue(int mappingLevel, MappingLevelControl control)
        {
            // Ensures that the absolute-value of a level is alwys lower than the absolue value of the next level
            if (mappingLevel + 1 < NumberOfLevels && control.AbsoluteValue >= mappingLevelControlList[mappingLevel + 1].AbsoluteValue)
            {
                mainForm.Log("Tried to set the absolute value of level '" + (mappingLevel + 1) + "' to '" + control.AbsoluteValue +
                    "'. But the absolute value of level '" + (mappingLevel + 2) + "' is '" + mappingLevelControlList[mappingLevel + 1].AbsoluteValue + "'");
                control.AbsoluteValue = mappingLevelControlList[mappingLevel + 1].AbsoluteValue - 1;
            }

            // Ensures that the absolute-value of a level is alwys higher than the absolue value of the previous level
            if (mappingLevel > 0 && control.AbsoluteValue <= mappingLevelControlList[mappingLevel - 1].AbsoluteValue)
            {
                mainForm.Log("Tried to set the absolute value of level '" + (mappingLevel + 1) + "' to '" + control.AbsoluteValue +
                    "'. But the absolute value of level '" + (mappingLevel) + "' is '" + mappingLevelControlList[mappingLevel - 1].AbsoluteValue + "'");
                control.AbsoluteValue = mappingLevelControlList[mappingLevel - 1].AbsoluteValue + 1;
            }
        }

        public int IncreaseToNextLevel(int sliderValue)
        {
            // Checks if the sliderValue is already as high/higher than the absoluteValue of the highest-level
            if (sliderValue >= mappingLevelControlList[NumberOfLevels-1].AbsoluteValue)
            {
                mainForm.Log("The slider value is equal or higher than the highest-level's value");
                return sliderValue;
            }

            // Iterates through all levels, beginning with the lowest until the absolute value of a level is higher than
            // 'sliderValue' then returns the absolute value of that level

            for (int i = 0; i < NumberOfLevels; i++)
            {
                if (mappingLevelControlList[i].AbsoluteValue > sliderValue)
                {
                    mainForm.Log("Setting slider value to Level '" + (i+1) + "'");
                    return mappingLevelControlList[i].AbsoluteValue;
                }
            }

            // Fallback case that should never run
            mainForm.Log("Found no level to set the slider to!");
            return sliderValue;
        }

        public int DecreaseToNextLevel(int sliderValue)
        {
            // Checks if the sliderValue is already as low/lower than the absoluteValue of the lowest-level
            if (sliderValue <= mappingLevelControlList[0].AbsoluteValue)
            {
                mainForm.Log("The slider value is equal or smaller than the lowest-level's value");
                return sliderValue;
            }

            // Iterates through all levels, beginning with the highest until the absolute value of a level is lower than
            // 'sliderValue' then returns the absolute value of that level
            for (int i = NumberOfLevels-1; i >= 0; i--)
            {
                if (mappingLevelControlList[i].AbsoluteValue < sliderValue)
                {
                    mainForm.Log("Setting slider value to Level '" + (i+1) + "'");
                    return mappingLevelControlList[i].AbsoluteValue;
                }
            }

            // Fallback case that should never run
            mainForm.Log("Found no level to set the slider to!");
            return sliderValue;
        }
        
        public void UpdateMaxSliderValueOfMappingLevelControls(uint newJoystickId, int newMax)
        {
            // Updates 'MaxAbsoluteSliderValue' variable of every mappingLevelControl
            foreach (MappingLevelControl mappingLevel in mappingLevelControlList)
            {
                mappingLevel.MaxAbsoluteSliderValue = newMax;
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
            SyncMappingThemeFlowLayoutPanelToLevelNumber((int)numberOfLevelsNumericUpDown.Value);
        }

        private void setValuesEqualyButton_Click(object sender, EventArgs e)
        {
            SetValuesOfLevelsEqualy();
        }
        
        private void MappingLevelAbsoluteNumericUpDown_ValueChanged(int mappingLevel, MappingLevelControl control)
        {
            CheckNewMappingLevelAbsoluteValue(mappingLevel, control);
            mainForm.Log("The absolute value of level '" + (mappingLevel + 1) + "' was changed to '" + control.AbsoluteValue + "'");
        }
        private void MappingLevelRelativeNumericUpDown_ValueChanged(int mappingLevel, MappingLevelControl control)
        {
            CheckNewMappingLevelAbsoluteValue(mappingLevel, control);
            mainForm.Log("The relative value of level '" + (mappingLevel + 1) + "' was changed to '" + control.RelativeNumericUpDownValue + "'");
        }

        #endregion
    }

    public class MappingLevelControl
    {
        #region Fields

        // Stores the mapping level index of the control
        int mappingLevel;
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

        public delegate void MappingLevelControlEventHandler(int mappingLevel, MappingLevelControl control);
        public event MappingLevelControlEventHandler MappingLevelAbsoluteNumericUpDown_ValueChanged;
        public event MappingLevelControlEventHandler MappingLevelRelativeNumericUpDown_ValueChanged;

        public MappingLevelControl(int mappingLevel, Control parent, int maxSliderValue)
        {
            // Saves the mapping level index of this controll and the maximum value oft he slider
            this.mappingLevel = mappingLevel;
            maxAbsoluteSliderValue = maxSliderValue;

            // Creates a GroupBox that stores all controls of the MappingLevelControl
            groupbox = new GroupBox();
            groupbox.Size = new Size(295, 68);
            groupbox.Text = "Level " + (mappingLevel + 1);

            //Creates an information label (has no advanced functionality)
            absoluteValueInfoLabel = new Label();
            absoluteValueInfoLabel.AutoSize = true;
            absoluteValueInfoLabel.Location = new Point(8, 18);
            absoluteValueInfoLabel.Text = "Absolute Value:";
            groupbox.Controls.Add(absoluteValueInfoLabel);

            //Creates a label that displays the absolute value of the MappingLevelControl
            absoluteValueLabel = new Label();
            absoluteValueLabel.AutoSize = true;
            absoluteValueLabel.Location = new Point(95, 18);
            absoluteValueLabel.Text = "-";
            groupbox.Controls.Add(absoluteValueLabel);

            //Creates a NumericUpDown that lets the user set the absolute value of the MappingLevelControl
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

            //Creates a label that displays the relative value of the MappingLevelControl
            relativeValueLabel = new Label();
            relativeValueLabel.AutoSize = true;
            relativeValueLabel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            relativeValueLabel.Location = new Point(95, 42);
            relativeValueLabel.Text = "-";
            groupbox.Controls.Add(relativeValueLabel);

            //Creates a NumericUpDown that lets the user set the relative value of the MappingLevelControl
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
        /// Removes all controls and unsubscribes off all events. Make sure that no method is subscribed to the events of the control!
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
            if(MappingLevelAbsoluteNumericUpDown_ValueChanged != null)
            {
                MappingLevelAbsoluteNumericUpDown_ValueChanged(mappingLevel, this);
            }
        }
        private void RelativeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            // Ignores the event
            if (ignoreEvents) return;

            RelativeValue = (int)relativeNumericUpDown.Value;
            // Invokes the event
            if (MappingLevelRelativeNumericUpDown_ValueChanged != null)
            {
                MappingLevelRelativeNumericUpDown_ValueChanged(mappingLevel, this);
            }
        }
    }
}
