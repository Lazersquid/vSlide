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
    public partial class VjoyInfoBox : UserControl
    {
        public bool IsVjoyInstalled
        {
            set { vjoyInstalledCheckBox.Checked = value; }
        }
        public string VjoyVersion
        {
            set { versionLabel.Text = value == null || value == "" ? "-" : value; }
        }
        public string VjoyDllVersion
        {
            set { dllVersionLabel.Text = value == null || value == "" ? "-" : value; }
        }

        public VjoyInfoBox()
        {
            InitializeComponent();
        }
    }
}
