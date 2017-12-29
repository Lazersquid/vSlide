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
    public partial class SliderLevelFactory : UserControl
    {
        protected bool isValueEditableByUser;
        public bool IsValueEditableByUser
        {
            get { return isValueEditableByUser; }
            set
            {
                numericUpDown.Enabled = value;
                isValueEditableByUser = value;
            }
        }
        
        public decimal Value
        {
            get { return numericUpDown.Value; }
            set
            {
                numericUpDown.Value = value;
            }
        }

        private int levelsNumber = 0;
        public int LevelsNumber
        {
            get { return levelsNumber; }
            set
            {
                levelsNumber = value;
                titleLabel.Text = string.Format("Level {0}", levelsNumber);
            }
        }

        public SliderLevelFactory()
        {
            InitializeComponent();
        }
    }
}
