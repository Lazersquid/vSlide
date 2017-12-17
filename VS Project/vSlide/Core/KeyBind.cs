using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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

        public readonly Keys BoundKey;
        public readonly Keys ControlMod = Keys.None;
        public readonly Keys ShiftMod = Keys.None;
        public readonly Keys AltMod = Keys.None;

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
            validKeys.Add(Keys.RShiftKey, "Right Shift");
            validKeys.Add(Keys.LControlKey, "Left Control");
            validKeys.Add(Keys.RControlKey, "Right Control");
            validKeys.Add(Keys.LMenu, "Left Alt");
            validKeys.Add(Keys.RMenu, "Right Alt");
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

        public static ImmutableArray<Keys> GetValidKeys()
        {
            return validKeys.Keys;
        }
        
        public static ImmutableArray<string> GetValidKeyNames()
        {
            return validKeys.KeyNames;
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

            ValidateKey(boundKey);
            ValidateKey(controlMod);
            ValidateKey(shiftMod);
            ValidateKey(altMod);

            // Prevents the bound key from getting set to None
            if (boundKey == Keys.None)
                throw new ArgumentOutOfRangeException(nameof(boundKey), string.Format(
                    "Can't set {0} to '{1}'!", nameof(boundKey), Keys.None));

            // Sets the control modifier to None if the new value is a control key
            if (controlMod != Keys.None && KeyService.IsCtrlKey(boundKey))
                controlMod = Keys.None;
            // Sets the shift modifier to None if the new value is a shift key
            if (shiftMod != Keys.None && KeyService.IsShiftKey(boundKey))
                shiftMod = Keys.None;
            // Sets the alt modifier to None if the new value is a alt key
            if (altMod != Keys.None && KeyService.IsAltKey(boundKey))
                altMod = Keys.None;
            BoundKey = boundKey;

            if (controlMod != Keys.None && !KeyService.IsCtrlKey(controlMod))
                throw new KeyValueOutOfRangeException(controlMod, "Can't set control mod of keybind!");
            if (KeyService.IsCtrlKey(boundKey))
                controlMod = Keys.None;
            ControlMod = controlMod;

            if (shiftMod != Keys.None && !KeyService.IsShiftKey(shiftMod))
                throw new KeyValueOutOfRangeException(shiftMod, "Can't set shift mod of keybind!");
            if (KeyService.IsShiftKey(boundKey))
                shiftMod = Keys.None;
            ShiftMod = shiftMod;

            if (altMod != Keys.None && !KeyService.IsAltKey(altMod))
                throw new KeyValueOutOfRangeException(altMod, "Can't set alt mod of keybind!");
            if (KeyService.IsAltKey(boundKey))
                altMod = Keys.None;
            AltMod = altMod;
        }

        public bool IsDown()
        {
            var result = KeyService.IsKeyDown(BoundKey);
            result = ControlMod == Keys.None ? result : result && KeyService.IsKeyDown(ControlMod);
            result = ShiftMod == Keys.None ? result : result && KeyService.IsKeyDown(ShiftMod);
            result = AltMod == Keys.None ? result : result && KeyService.IsKeyDown(AltMod);
            return result;
        }

        public override string ToString()
        {
            var strings = new List<string>();
            if (ControlMod != Keys.None)
                strings.Add(GetKeyName(ControlMod));
            if (ShiftMod != Keys.None)
                strings.Add(GetKeyName(ShiftMod));
            if (AltMod != Keys.None)
                strings.Add(GetKeyName(AltMod));
            strings.Add(GetKeyName(BoundKey));

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
