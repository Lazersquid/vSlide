using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vSlide
{
    public class KeyBind
    {
        private Keys boundKey;
        public Keys BoundKey
        {
            get
            {
                return boundKey;
            }
            set
            {
                // Prevents the bound key from getting set to None
                if (value == Keys.None)
                    throw new ArgumentOutOfRangeException(nameof(value), string.Format(
                        "Can't set {0} to '{1}'!", nameof(boundKey), Keys.None));

                // Sets the control modifier to None if the new value is a control key
                if (controlMod != Keys.None && KeyService.IsCtrlKey(value))
                    ControlMod = Keys.None;
                // Sets the shift modifier to None if the new value is a shift key
                if (shiftMod != Keys.None && KeyService.IsShiftKey(value))
                    ShiftMod = Keys.None;
                // Sets the alt modifier to None if the new value is a alt key
                if (altMod != Keys.None && KeyService.IsAltKey(value))
                    AltMod = Keys.None;

                boundKey = value;
            }
        }
        private Keys controlMod;
        public Keys ControlMod
        {
            get
            {
                return controlMod;
            }
            set
            {
                if (value != Keys.None && !KeyService.IsCtrlKey(value))
                    throw new KeyValueOutOfRangeException(value, "Can't set control mod of keybind!");

                if (KeyService.IsCtrlKey(boundKey))
                    value = Keys.None;

                controlMod = value;
            }
        }
        private Keys shiftMod;
        public Keys ShiftMod
        {
            get
            {
                return shiftMod;
            }
            set
            {
                if (value != Keys.None && !KeyService.IsShiftKey(value))
                    throw new KeyValueOutOfRangeException(value, "Can't set shift mod of keybind!");

                if (KeyService.IsShiftKey(boundKey))
                    value = Keys.None;

                shiftMod = value;
            }
        }
        private Keys altMod;
        public Keys AltMod
        {
            get
            {
                return altMod;
            }
            set
            {
                if (value != Keys.None && !KeyService.IsAltKey(value))
                    throw new KeyValueOutOfRangeException(value, "Can't set alt mod of keybind!");

                if (KeyService.IsAltKey(boundKey))
                    value = Keys.None;

                altMod = value;
            }
        }
    }
}
