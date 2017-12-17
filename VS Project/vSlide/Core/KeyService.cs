using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Immutable;

namespace vSlide
{
    public static class KeyService
    {
        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(Keys vKey);

        public static readonly ImmutableArray<Keys> ctrlKeys = ImmutableArray.Create(
            Keys.LControlKey, Keys.RControlKey);

        public static readonly ImmutableArray<Keys> shiftKeys = ImmutableArray.Create(
            Keys.LShiftKey, Keys.RShiftKey);

        public static readonly ImmutableArray<Keys> altKeys = ImmutableArray.Create(
            Keys.LMenu, Keys.RMenu);

        public static bool IsKeyDown(Keys key)
        {
            return GetAsyncKeyState(key) != 0;
        }

        public static bool IsCtrlKey(Keys key)
        {
            return ctrlKeys.Contains(key);
        }

        public static bool IsShiftKey(Keys key)
        {
            return shiftKeys.Contains(key);
        }

        public static bool IsAltKey(Keys key)
        {
            return altKeys.Contains(key);
        }
    }
}
