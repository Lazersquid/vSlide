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
    public partial class KeyBindControl : UserControl
    {
        protected KeyBind keyBind;
        public string Title
        {
            get { return titleLabel.Text; }

            set
            {
                titleLabel.Text = value;
            }
        }
        public KeyBind KeyBind { get { return new KeyBind(keyBind.BoundKey, keyBind.ControlMod, keyBind.ShiftMod, keyBind.AltMod); } }

        public KeyBindControl()
        {
            InitializeComponent();
            
            keyBind = new KeyBind(Keys.LShiftKey, Keys.None, Keys.None, Keys.None);
            rebindButton.Click += RebindButton_Click;

            Title = "Key:";
            UpdateKeyBindLabel();
        }

        protected void RebindButton_Click(object sender, EventArgs e)
        {

        }

        protected void UpdateKeyBindLabel()
        {
            keyBindLabel.Text = keyBind.ToString();
        }
    }
}
