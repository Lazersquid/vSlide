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
            get { return timeNumericUpDown.Maximum; }
            set
            {
                value = Math.Max(value, Minimum);
                timeNumericUpDown.Maximum = value;
            }
        }
        public decimal Minimum
        {
            get { return timeNumericUpDown.Minimum; }
            set
            {
                value = Math.Min(value, Maximum);
                timeNumericUpDown.Minimum = value;
            }
        }
        public int DecimalDigits
        {
            get { return timeNumericUpDown.DecimalPlaces; }
            set
            {
                timeNumericUpDown.DecimalPlaces = value;
            }
        }
        public decimal Increment
        {
            get { return timeNumericUpDown.Increment; }
            set
            {
                timeNumericUpDown.Increment = value;
            }
        }
        public decimal StepSize
        {
            get { return stepSize; }
            set
            {
                value = Math.Min(value, 1);
                value = Math.Max(value, 0);
                stepSize = value;
            }
        }
        public decimal Value
        {
            get { return timeNumericUpDown.Value; }
            set
            {
                value = Math.Min(value, Maximum);
                value = Math.Max(value, Minimum);
                timeNumericUpDown.Value = value;
            }
        }

        public DecimalControl()
        {
            InitializeComponent();

            Initialize("Amount:", "ms", 100, -100, 1, 5, 0.5M, 5);
        }

        public DecimalControl(string title, string suffix, decimal maximum, decimal minimum, int decimalDigits, decimal increment, decimal stepSize, decimal value)
        {
            InitializeComponent();
            Initialize(title, suffix, maximum, minimum, decimalDigits, increment, stepSize, value);
        }

        protected void Initialize(string title, string suffix, decimal maximum, decimal minimum, int decimalDigits, decimal increment, decimal stepSize, decimal value)
        {
            Title = title;
            Suffix = suffix;
            Maximum = maximum;
            Minimum = minimum;
            DecimalDigits = decimalDigits;
            Increment = increment;
            StepSize = stepSize;
            Value = value;
        }
    }
}
