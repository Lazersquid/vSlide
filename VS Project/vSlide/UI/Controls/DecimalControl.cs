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
    public partial class DecimalControl : UserControl
    {
        protected decimal stepSize;
        public string Title
        {
            get { return titleLabel.Text; }

            set
            {
                titleLabel.Text = value;
            }
        }
        public string Suffix
        {
            get { return suffixLabel.Text; }
            set
            {
                suffixLabel.Text = value;
            }
        }
        public decimal Maximum
        {
            get { return numericUpDown.Maximum; }
            set
            {
                value = ClampToResolution(value);
                value = Math.Max(value, Minimum);
                numericUpDown.Maximum = value;
            }
        }
        public decimal Minimum
        {
            get { return numericUpDown.Minimum; }
            set
            {
                value = ClampToResolution(value);
                value = Math.Min(value, Maximum);
                numericUpDown.Minimum = value;
            }
        }
        public int DecimalDigits
        {
            get { return numericUpDown.DecimalPlaces; }
            set
            {
                numericUpDown.DecimalPlaces = value;
            }
        }
        public decimal NumericUpDownIncrement
        {
            get { return numericUpDown.Increment; }
            set
            {
                value = ClampToResolution(value);
                numericUpDown.Increment = value;
            }
        }

        public decimal Resolution
        {
            get { return stepSize; }
            set
            {
                value = Math.Max(value, 0);
                stepSize = value;
            }
        }
        public decimal Value
        {
            get { return numericUpDown.Value; }
            set
            {
                value = ClampToResolution(value);
                value = Math.Min(value, Maximum);
                value = Math.Max(value, Minimum);
                numericUpDown.Value = value;
            }
        }
        public decimal ValueAsFactor
        {
            get
            {
                var value = Value / 100;
                Math.Min(value, 1);
                Math.Max(value, 0);
                return value;
            }
        }
        public int NumericUpDownWidth
        {
            get { return numericUpDown.Size.Width; }
            set
            {
                numericUpDown.Size = new Size(value, numericUpDown.Size.Height);
            }
        }

        public DecimalControl()
        {
            InitializeComponent();

            numericUpDown.ValueChanged += NumericUpDown_ValueChanged;
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Value = numericUpDown.Value;
        }

        protected decimal ClampToResolution(decimal value)
        {
            return Resolution == 0 ? value : value - (value % Resolution);
        }
    }
}
