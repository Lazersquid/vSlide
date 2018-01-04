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
    public partial class SliderView : UserControl
    {
        protected decimal cachedSliderValue = 0;
        public decimal SliderValue
        {
            get { return decimal.Divide(sliderTrackBar.Value, 100); }
        }
        protected string prefix = "Slider Value: ";
        public string Prefix
        {
            get { return prefix; }
            set
            {
                prefix = value ?? throw new ArgumentNullException();
            }
        }
        protected string suffix = "%";
        public string Suffix
        {
            get { return suffix; }
            set
            {
                suffix = value ?? throw new ArgumentNullException();
            }
        }

        public SliderView()
        {
            InitializeComponent();
        }

        public void SetValue(decimal value, bool fireEvent)
        {
            value = Math.Max(value, 0);
            value = Math.Min(value, 1);
            value *= 100;
            value = decimal.Round(value, 2);
            if (value == cachedSliderValue) return;

            cachedSliderValue = value;
            sliderTrackBar.Value = decimal.ToInt32(value);
            groupBox.Text = prefix + value.ToString() + suffix;
        }
    }
}
