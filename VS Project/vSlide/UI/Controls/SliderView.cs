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
        public event EventHandler ValueChanged;

        protected bool fireEventFlag = true;
        protected int cachedSliderValue = 0;
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
                if (value == null) throw new ArgumentNullException();
                prefix = value;
            }
        }
        protected string suffix = "%";
        public string Suffix
        {
            get { return suffix; }
            set
            {
                if (value == null) throw new ArgumentNullException();
                suffix = value;
            }
        }

        public SliderView()
        {
            InitializeComponent();
        }

        protected void sliderTrackBar_ValueChanged(object sender, EventArgs e)
        {
            cachedSliderValue = sliderTrackBar.Value;
            if (fireEventFlag && ValueChanged != null)
                ValueChanged(this, e);
        }

        public void SetValue(decimal value, bool fireEvent)
        {
            value = Math.Max(value, 0);
            value = Math.Min(value, 1);
            var newValue = decimal.ToInt32(value * 100);

            if (newValue == cachedSliderValue) return;
            fireEventFlag = fireEvent;
            sliderTrackBar.Value = newValue;
            fireEventFlag = true;
            groupBox.Text = prefix + newValue.ToString() + suffix;
        }
    }
}
