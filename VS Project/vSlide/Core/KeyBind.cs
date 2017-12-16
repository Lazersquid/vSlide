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
        protected static KeyCollection validKeys;

        protected Keys boundKey;
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
                    controlMod = Keys.None;
                // Sets the shift modifier to None if the new value is a shift key
                if (shiftMod != Keys.None && KeyService.IsShiftKey(value))
                    shiftMod = Keys.None;
                // Sets the alt modifier to None if the new value is a alt key
                if (altMod != Keys.None && KeyService.IsAltKey(value))
                    altMod = Keys.None;

                boundKey = value;
            }
        }
        protected Keys controlMod = Keys.None;
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
        protected Keys shiftMod = Keys.None;
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
        protected Keys altMod = Keys.None;
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

        #region static methods
        protected static void SetValidKeys()
        {
            if (validKeys != null) return;

            validKeys = new KeyCollection();
            validKeys.Add(Keys.None, "None");

            validKeys.Add(Keys.Q, "Q");
            validKeys.Add(Keys.E, "E");
            validKeys.Add(Keys.R, "R");
            validKeys.Add(Keys.F, "F");
            validKeys.Add(Keys.LShiftKey, "Left Shift");
            validKeys.Add(Keys.LControlKey, "Left Control");
            validKeys.Add(Keys.LMenu, "Left Alt");
        }

        public static Keys GetKey(string keyName)
        {
            SetValidKeys();
            return validKeys.GetKey(keyName);
        }

        public static string GetKeyName(Keys key)
        {
            SetValidKeys();
            return validKeys.GetKeyName(key);
        }

        protected static void ValidateKey(Keys key)
        {
            SetValidKeys();
            if (key != Keys.None && !validKeys.ContainsKey(key))
                throw new KeyValueOutOfRangeException(key);
        }
        #endregion

        public KeyBind(Keys boundKey, Keys controlMod, Keys shiftMod, Keys altMod)
        {
            SetValidKeys();
            Rebind(boundKey, controlMod, shiftMod, altMod);
        }

        public void Rebind(Keys boundKey, Keys controlMod, Keys shiftMod, Keys altMod)
        {
            ValidateKey(boundKey);
            ValidateKey(controlMod);
            ValidateKey(shiftMod);
            ValidateKey(altMod);

            BoundKey = boundKey;
            ControlMod = controlMod;
            ShiftMod = shiftMod;
            AltMod = altMod;
        }

        public bool IsDown()
        {
            var result = KeyService.IsKeyDown(boundKey);
            result = controlMod == Keys.None ? result : result && KeyService.IsKeyDown(controlMod);
            result = shiftMod == Keys.None ? result : result && KeyService.IsKeyDown(shiftMod);
            result = altMod == Keys.None ? result : result && KeyService.IsKeyDown(altMod);
            return result;
        }

        public override string ToString()
        {
            var strings = new List<string>();
            if (controlMod != Keys.None)
                strings.Add(GetKeyName(controlMod));
            if (shiftMod != Keys.None)
                strings.Add(GetKeyName(shiftMod));
            if (altMod != Keys.None)
                strings.Add(GetKeyName(altMod));
            strings.Add(GetKeyName(boundKey));

            var str = "";
            for(int i = 0; i < strings.Count; i++)
            {
                if (i > 0) str += " + ";
                str += "'" + strings[i] + "'";
            }

            return str;
        }
    }
}
