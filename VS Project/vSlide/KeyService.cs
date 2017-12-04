using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vSlide
{
    public static class KeyService
    {
        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(Keys vKey);

        public static bool IsKeyDown(Keys key)
        {
            return GetAsyncKeyState(key) != 0;
        }

        public static bool IsCtrlKey(Keys key)
        {
            return key == Keys.ControlKey || key == Keys.LControlKey || key == Keys.RControlKey;
        }

        public static bool IsShiftKey(Keys key)
        {
            return key == Keys.ShiftKey || key == Keys.LShiftKey || key == Keys.RShiftKey;
        }

        public static bool IsAltKey(Keys key)
        {
            return key == Keys.Menu || key == Keys.LMenu || key == Keys.RMenu;
        }
    }
}
