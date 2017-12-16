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
        public SliderManipulatorPanel()
        {
            InitializeComponent();
            
            addButton.Click += AddButton_Click;
            AddManipulator();
        }

        protected void AddManipulator()
        {
            AddManipulator(new SliderManipulatorFactory(
                new WhenKeyPressedTriggerFactory(),
                new ModifySliderValueActionFactory()));
        }

        protected void AddManipulator(SliderManipulatorFactory manipulator)
        {
            manipulatorsPanel.Controls.Add(manipulator);
            manipulator.DeleteButtonClick += Manipulator_DeleteButtonClick;
        }

        protected void RemoveManipulator(SliderManipulatorFactory manipulator)
        {
            manipulator.DeleteButtonClick -= Manipulator_DeleteButtonClick;
            Controls.Remove(manipulator);
            manipulator.Dispose();
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
    }
}
