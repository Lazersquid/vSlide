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
    public partial class SliderManipulatorFactory : UserControl
    {
        protected ISliderTriggerFactory triggerFactory;
        protected ISliderActionFactory actionFactory;

        public event EventHandler DeleteButtonClick;

        public SliderManipulatorFactory(ISliderTriggerFactory triggerFactory, ISliderActionFactory actionFactory)
        {
            InitializeComponent();
            
            this.triggerFactory = triggerFactory;
            triggerFactory.Control.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.Controls.Add(triggerFactory.Control, 1, 0);

            this.actionFactory = actionFactory;
            actionFactory.Control.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.Controls.Add(actionFactory.Control, 3, 0);

            deleteButton.Click += DeleteButton_Click;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (DeleteButtonClick != null)
                DeleteButtonClick(this, e);
        }

        public SliderManipulator CreateManipulator()
        {
            return new SliderManipulator(triggerFactory.CreateTrigger(), actionFactory.CreateAction());
        }
    }
}
