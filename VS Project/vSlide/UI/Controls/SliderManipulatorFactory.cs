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
    public partial class SliderManipulatorFactory : UserControl, IRebindSubscriber
    {
        protected const int triggerFactoryTableIndex = 2;
        protected const int actionFactoryTableIndex = 5;
        public readonly ISliderTriggerFactory triggerFactory;
        public readonly ISliderActionFactory actionFactory;

        public Factory<ISliderTriggerFactory> SelectedTriggerSwapFactory
        {
            get
            {
                return triggerFactoryComboBox.SelectedItem as Factory<ISliderTriggerFactory>;
            }
        }
        public Factory<ISliderActionFactory> SelectedActionSwapFactory
        {
            get
            {
                return actionFactoryComboBox.SelectedItem as Factory<ISliderActionFactory>;
            }
        }

        public event EventHandler DeleteButtonClick;
        public event EventHandler SelectedTriggerFactoryChanged;
        public event EventHandler SelectedActionFactoryChanged;

        public SliderManipulatorFactory(ISliderTriggerFactory triggerFactory, ISliderActionFactory actionFactory,
            Factory<ISliderTriggerFactory>[] triggerSwapFactories, Factory<ISliderActionFactory>[] actionSwapFactories)
        {
            InitializeComponent();

            this.triggerFactory = triggerFactory;
            triggerFactory.Control.Anchor = AnchorStyles.Left;
            tableLayoutPanel.Controls.Add(triggerFactory.Control, triggerFactoryTableIndex, 0);

            this.actionFactory = actionFactory;
            actionFactory.Control.Anchor = AnchorStyles.Left;
            tableLayoutPanel.Controls.Add(actionFactory.Control, actionFactoryTableIndex, 0);
            
            triggerFactoryComboBox.DisplayMember = "DisplayString";
            triggerFactoryComboBox.Items.Clear();
            triggerFactoryComboBox.Items.AddRange(triggerSwapFactories);

            actionFactoryComboBox.DisplayMember = "DisplayString";
            actionFactoryComboBox.Items.Clear();
            actionFactoryComboBox.Items.AddRange(actionSwapFactories);

            triggerFactoryComboBox.SelectionChangeCommitted += TriggerFactoryComboBox_SelectedValueChanged;
            actionFactoryComboBox.SelectionChangeCommitted += ActionFactoryComboBox_SelectedValueChanged;
            deleteButton.Click += DeleteButton_Click;
        }

        public SliderManipulator CreateManipulator()
        {
            return new SliderManipulator(triggerFactory.CreateTrigger(), actionFactory.CreateAction());
        }

        public void SubscribeToRebindInitializationCallback(RebindInitializeHandler initializeRebindCallback)
        {
            triggerFactory.SubscribeToRebindInitializationCallback(initializeRebindCallback);
        }

        public void UnsubscribeFromRebindInitializationCallback(RebindInitializeHandler initializeRebindCallback)
        {
            triggerFactory.UnsubscribeFromRebindInitializationCallback(initializeRebindCallback);
        }

        #region event callbacks
        protected void TriggerFactoryComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            SelectedTriggerFactoryChanged?.Invoke(this, e);
        }

        protected void ActionFactoryComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            SelectedActionFactoryChanged?.Invoke(this, e);
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteButtonClick?.Invoke(this, e);
        }
        #endregion

    }
}
