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

    public partial class SliderManipulatorPanel : UserControl
    {
        public const int MaxManipulatorCount = 50;
        protected IRebindable rebindingRebindable;
        public bool IsRebinding
        {
            get { return rebindingRebindable != null; }
        }

        public SliderManipulatorPanel()
        {
            InitializeComponent();
            rebindGroupBox.Enabled = false;
            rebindGroupBox.Visible = false;

            addManipulatorButton.Click += AddButton_Click;
            applyButton.Click += ApplyButton_Click;
            cancelButton.Click += CancelButton_Click;
            EnabledChanged += SliderManipulatorPanel_EnabledChanged;

            SetComboBoxRangeToKeys(ctrlComboBox, KeyService.ctrlKeys.Add(Keys.None));
            SetComboBoxRangeToKeys(shiftComboBox, KeyService.shiftKeys.Add(Keys.None));
            SetComboBoxRangeToKeys(altComboBox, KeyService.altKeys.Add(Keys.None));
            SetComboBoxRangeToKeys(keyComboBox, KeyBind.GetValidKeys().Remove(Keys.None));

            AddManipulator();
        }

        protected void SetComboBoxRangeToKeys(ComboBox comboBox, IEnumerable<Keys> keys)
        {
            comboBox.Items.Clear();
            foreach(var key in keys)
            {
                comboBox.Items.Add(KeyBind.GetKeyName(key));
            }
        }

        protected void AddManipulator()
        {

            AddManipulator(new SliderManipulatorFactory(
                new WhenKeyPressedTriggerFactory(),
                new ModifySliderValueActionFactory()));
        }

        protected void AddManipulator(SliderManipulatorFactory manipulator)
        {
            if (manipulatorsPanel.Controls.Count >= MaxManipulatorCount)
            {
                MessageBox.Show(
                    string.Format("The maximum count of {0} manipulators is reached!", MaxManipulatorCount),
                    "Can't add another manipulator!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            manipulatorsPanel.Controls.Add(manipulator);
            manipulator.DeleteButtonClick += Manipulator_DeleteButtonClick;
            manipulator.SubscribeToRebindInitializationCallback(Rebindable_RebindInitialization);
        }

        protected void RemoveManipulator(SliderManipulatorFactory manipulator)
        {
            if (IsRebinding) LeaveRebindingState();
            manipulator.DeleteButtonClick -= Manipulator_DeleteButtonClick;
            Controls.Remove(manipulator);
            manipulator.Dispose();
        }

        protected void EnterRebindingState(IRebindable newRebindingRebindable)
        {
            if (IsRebinding) throw new InvalidOperationException("already rebinding!");
            var keyBind = newRebindingRebindable.KeyBind;
            ctrlComboBox.SelectedItem = KeyBind.GetKeyName(keyBind.ControlMod);
            shiftComboBox.SelectedItem = KeyBind.GetKeyName(keyBind.ShiftMod);
            altComboBox.SelectedItem = KeyBind.GetKeyName(keyBind.AltMod);
            keyComboBox.SelectedItem = KeyBind.GetKeyName(keyBind.BoundKey);
            rebindGroupBox.Enabled = true;
            rebindGroupBox.Visible = true;
            manipulatorsPanel.Enabled = false;
            addManipulatorButton.Enabled = false;
            rebindingRebindable = newRebindingRebindable;
        }

        protected void LeaveRebindingState()
        {
            if (!IsRebinding) throw new InvalidOperationException("not rebinding!");
            rebindGroupBox.Enabled = false;
            rebindGroupBox.Visible = false;
            manipulatorsPanel.Enabled = true;
            addManipulatorButton.Enabled = true;
            rebindingRebindable = null;
        }

        public List<SliderManipulator> CreateManipulators()
        {
            var manipulators = new List<SliderManipulator>();
            foreach (var control in manipulatorsPanel.Controls)
            {
                if (!(control is SliderManipulatorFactory))
                    throw new ArgumentOutOfRangeException();
                var manipulatorFactory = (SliderManipulatorFactory)control;
                manipulators.Add(manipulatorFactory.CreateManipulator());
            }

            return manipulators;
        }

        #region event callbacks
        protected void Rebindable_RebindInitialization(IRebindable sender)
        {
            EnterRebindingState(sender);
        }

        protected void ApplyButton_Click(object sender, EventArgs e)
        {
            if (!IsRebinding) throw new InvalidOperationException("is not rebinding!");

            var key = KeyBind.GetKey(keyComboBox.SelectedItem.ToString());
            var ctrlKey = KeyBind.GetKey(ctrlComboBox.SelectedItem.ToString());
            var shiftKey = KeyBind.GetKey(shiftComboBox.SelectedItem.ToString());
            var alt = KeyBind.GetKey(altComboBox.SelectedItem.ToString());
            var newKeyBind = new KeyBind(key, ctrlKey, shiftKey, alt);

            rebindingRebindable.KeyBind = newKeyBind;
            LeaveRebindingState();
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            if (!IsRebinding) throw new InvalidOperationException("is not rebinding!");
            LeaveRebindingState();
        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            AddManipulator();
        }

        protected void Manipulator_DeleteButtonClick(object sender, EventArgs e)
        {
            if (!(sender is SliderManipulatorFactory))
                throw new ArgumentOutOfRangeException();
            RemoveManipulator((SliderManipulatorFactory)sender);
        }

        protected void SliderManipulatorPanel_EnabledChanged(object sender, EventArgs e)
        {
            if (IsRebinding) LeaveRebindingState();
        }
        #endregion
    }
}
