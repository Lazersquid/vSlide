using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Immutable;

namespace vSlide
{

    public partial class SliderManipulatorPanel : UserControl
    {
        protected IRebindable rebindingRebindable;
        protected int maximumManipulators = 50;
        public int MaximumManipulators
        {
            get { return maximumManipulators; }
            set
            {
                Math.Max(value, 0);
                maximumManipulators = value;
            }
        }
        public bool IsRebinding
        {
            get { return rebindingRebindable != null; }
        }

        protected static readonly ImmutableArray<Factory<ISliderTriggerFactory>> triggerSwapFactories = ImmutableArray.Create(
            new Factory<ISliderTriggerFactory>(Activator.CreateInstance<WhenKeyPressedTriggerFactory>, "On key pressed"),
            new Factory<ISliderTriggerFactory>(Activator.CreateInstance<WhileKeyPressedTriggerFactory>, "While key pressed")
            );

        protected static readonly ImmutableArray<Factory<ISliderActionFactory>> actionSwapFactories = ImmutableArray.Create(
            new Factory<ISliderActionFactory>(Activator.CreateInstance<ModifySliderValueActionFactory>, "Modify slider by"),
            new Factory<ISliderActionFactory>(Activator.CreateInstance<SetSliderValueActionFactory>, "Set slider to"),
            new Factory<ISliderActionFactory>(Activator.CreateInstance<NextSliderLevelActionFactory>, "Jump to next greater slider level"),
            new Factory<ISliderActionFactory>(Activator.CreateInstance<PreviousSliderLevelActionFactory>, "Jump to next smaller slider level")
            );


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
                new ModifySliderValueActionFactory(),
                triggerSwapFactories.ToArray(),
                actionSwapFactories.ToArray()));
        }

        protected void AddManipulator(SliderManipulatorFactory manipulator)
        {
            if (manipulatorsPanel.Controls.Count >= maximumManipulators)
            {
                MessageBox.Show(
                    string.Format("The maximum count of {0} manipulators is reached!", maximumManipulators),
                    "Can't add another manipulator!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            manipulatorsPanel.Controls.Add(manipulator);
            manipulator.DeleteButtonClick += Manipulator_DeleteButtonClick;
            manipulator.SelectedTriggerFactoryChanged += Manipulator_SelectedTriggerFactoryChanged;
            manipulator.SelectedActionFactoryChanged += Manipulator_SelectedActionFactoryChanged;
            manipulator.SubscribeToRebindInitializationCallback(Rebindable_RebindInitialization);
        }

        protected void RemoveManipulator(SliderManipulatorFactory manipulator)
        {
            if (IsRebinding) LeaveRebindingState();
            manipulator.DeleteButtonClick -= Manipulator_DeleteButtonClick;
            manipulator.SelectedTriggerFactoryChanged -= Manipulator_SelectedTriggerFactoryChanged;
            manipulator.SelectedActionFactoryChanged -= Manipulator_SelectedActionFactoryChanged;
            manipulator.UnsubscribeFromRebindInitializationCallback(Rebindable_RebindInitialization);
            Controls.Remove(manipulator);
            manipulator.Dispose();
        }

        protected void ReplaceManipulator(SliderManipulatorFactory oldManipulator, SliderManipulatorFactory newManipulator)
        {
            var index = manipulatorsPanel.Controls.IndexOf(oldManipulator);
            RemoveManipulator(oldManipulator);
            AddManipulator(newManipulator);
            manipulatorsPanel.Controls.SetChildIndex(newManipulator, index);
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

        protected void Manipulator_SelectedTriggerFactoryChanged(object sender, EventArgs e)
        {
            if (!(sender is SliderManipulatorFactory))
                throw new ArgumentOutOfRangeException();

            var manipulator = (SliderManipulatorFactory)sender;
            var newTriggerFactory = manipulator.SelectedTriggerSwapFactory.CreateInstance();
            ReplaceManipulator(manipulator, new SliderManipulatorFactory(
                newTriggerFactory, manipulator.actionFactory, triggerSwapFactories.ToArray(), actionSwapFactories.ToArray()));
        }

        protected void Manipulator_SelectedActionFactoryChanged(object sender, EventArgs e)
        {
            if (!(sender is SliderManipulatorFactory))
                throw new ArgumentOutOfRangeException();

            var manipulator = (SliderManipulatorFactory)sender;
            var newActionFactory = manipulator.SelectedActionSwapFactory.CreateInstance();
            ReplaceManipulator(manipulator, new SliderManipulatorFactory(
                manipulator.triggerFactory, newActionFactory, triggerSwapFactories.ToArray(), actionSwapFactories.ToArray()));
        }

        protected void SliderManipulatorPanel_EnabledChanged(object sender, EventArgs e)
        {
            if (IsRebinding) LeaveRebindingState();
        }
        #endregion
    }
}
