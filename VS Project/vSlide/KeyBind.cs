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
                // Prevents the key from getting set to None
                if (value == Keys.None)
                {
                    Console.WriteLine("Tried to set BoundKey to 'Keys.None'!");
                    throw new ArgumentException("Tried to set BoundKey to 'Keys.None'!");
                }

                // Sets the control modifier key to None if the new value is a control key
                if(controlMod != Keys.None && (value == Keys.ControlKey || value == Keys.LControlKey || value == Keys.RControlKey))
                {
                    controlMod = Keys.None;
                }
                // Sets the shift modifier key to None if the new value is a shift key
                if (shiftMod != Keys.None && (value == Keys.ShiftKey || value == Keys.LShiftKey || value == Keys.RShiftKey))
                {
                    shiftMod = Keys.None;
                }
                // Sets the alt modifier key to None if the new value is a alt key
                if (altMod != Keys.None && (value == Keys.Menu || value == Keys.LMenu || value == Keys.RMenu))
                {
                    altMod = Keys.None;
                }

                boundKey = value;
                currState = KeyState.Up;
                currDownTime = 0;
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
                // Prevents the key from getting set to None
                if (value != Keys.None && value != Keys.ControlKey && value != Keys.LControlKey && value != Keys.RControlKey)
                {
                    Console.WriteLine("Tried to set ControlMod to '" + value + "'!");
                    throw new ArgumentException("Tried to set ControlMod to '" + value + "'!");
                }

                if (value != Keys.None && (boundKey == Keys.ControlKey || boundKey == Keys.LControlKey || boundKey == Keys.RControlKey))
                {
                    value = Keys.None;
                }

                controlMod = value;
                currState = KeyState.Up;
                currDownTime = 0;
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
                // Prevents the key from getting set to None
                if (value != Keys.None && value != Keys.ShiftKey && value != Keys.LShiftKey && value != Keys.RShiftKey)
                {
                    Console.WriteLine("Tried to set 'ShiftMod' to '" + value + "'!");
                    throw new ArgumentException("Tried to set 'ShiftMod' to '" + value + "'!");
                }

                if (value != Keys.None && (boundKey == Keys.ShiftKey || boundKey == Keys.LShiftKey || boundKey == Keys.RShiftKey))
                {
                    value = Keys.None;
                }

                shiftMod = value;
                currState = KeyState.Up;
                currDownTime = 0;
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
                // Prevents the key from getting set to None
                if (value != Keys.None && value != Keys.Menu && value != Keys.LMenu && value != Keys.RMenu)
                {
                    Console.WriteLine("Tried to set 'AltMod' to '" + value + "'!");
                    throw new ArgumentException("Tried to set 'AltMod' to '" + value + "'!");
                }

                if (value != Keys.None && (boundKey == Keys.Menu || boundKey == Keys.LMenu || boundKey == Keys.RMenu))
                {
                    value = Keys.None;
                }

                altMod = value;
                currState = KeyState.Up;
                currDownTime = 0;
            }
        }
        private KeyState currState;
        private bool useHeldDown;
        public bool UseHeldDown
        {
            get { return useHeldDown; }
        }
        private uint heldDownTreshold;
        public uint HeldDownTreshold
        {
            get { return heldDownTreshold; }
            set
            {
                // Checks if the held down logic is enabled
                if (!useHeldDown)
                {
                    Console.WriteLine("Tried to set HeldDownTreshold while useHeldDown was '" + useHeldDown + "'!");
                    throw new InvalidOperationException("Tried to set HeldDownTreshold while useHeldDown was '" + useHeldDown + "'!");
                }

                heldDownTreshold = value;
            }
        }
        private uint heldDownTickInterval;
        public uint HeldDownTickInterval
        {
            get { return heldDownTickInterval; }
            set
            {
                // Checks if the held down logic is enabled
                if(!useHeldDown)
                {
                    Console.WriteLine("Tried to set HeldDownTickInterval while useHeldDown was '" + useHeldDown + "'!");
                    throw new InvalidOperationException("Tried to set HeldDownTickInterval while useHeldDown was '" + useHeldDown + "'!");
                }

                // Prevents the tick interval from beeing set to 0
                if (value == 0)
                {
                    Console.WriteLine("Tried to set HeldDownTickInterval to '" + value + "'!");
                    throw new ArgumentException("Tried to set HeldDownTickInterval to '" + value + "'!");
                }
                heldDownTickInterval = value;
            }
        }
        private uint currDownTime;

        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(Keys vKey);

        /// <summary>
        /// Creates a new key bind with disabled held down mode
        /// </summary>
        /// <param name="boundKey"> The key to which the key bind is bound </param>
        /// <param name="controlMod"> The contol key modifier </param>
        /// <param name="shiftMod"> The shift key modifier </param>
        /// <param name="altMod"> The alt key modifier </param>
        public KeyBind(Keys boundKey, Keys controlMod, Keys shiftMod, Keys altMod)
        {
            this.ControlMod = controlMod;
            this.ShiftMod = shiftMod;
            this.AltMod = altMod;
            this.BoundKey = boundKey;

            this.useHeldDown = false;
            this.currDownTime = 0;
            this.heldDownTreshold = 0;
            this.heldDownTickInterval = 0;
        }
        
        /// <summary>
        /// Creates a new key bind with disabled held down mode
        /// </summary>
        /// <param name="boundKey"> The key to which the key bind is bound </param>
        public KeyBind(Keys boundKey)
        {
            this.ControlMod = Keys.None;
            this.ShiftMod = Keys.None;
            this.AltMod = Keys.None;
            this.BoundKey = boundKey;

            this.currState = KeyState.Up;
            this.useHeldDown = false;
            this.currDownTime = 0;
            this.heldDownTreshold = 0;
            this.heldDownTickInterval = 0;
        }

        /// <summary>
        /// Rebinds the keys
        /// </summary>
        /// <param name="boundKey"> The new key </param>
        /// <param name="controlMod"> The new control key modifier </param>
        /// <param name="shiftMod"> The new shift key modifier </param>
        /// <param name="altMod"> The new alt key modifier </param>
        public void SetKeys(Keys boundKey, Keys controlMod, Keys shiftMod, Keys altMod)
        {
            this.ControlMod = controlMod;
            this.ShiftMod = shiftMod;
            this.AltMod = altMod;
            this.BoundKey = boundKey;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Reset()
        {
            currState = KeyState.Up;
            currDownTime = 0;
        }

        /// <summary>
        /// Updates the keybind to check if its Up, Down or HeldDown and returns the current state of the key bind
        /// </summary>
        /// <param name="elapsedTime"> The time that elapsed since the last update, 0 is a valid value </param>
        /// <returns></returns>
        public KeyUpdateReport UpdateKey(uint elapsedTime)
        {
            KeyState oldState = currState;
            currState = GetAsyncKeyState(boundKey) == 0 ? KeyState.Up : KeyState.Down;
            
            if (controlMod == Keys.None && boundKey != Keys.ControlKey && boundKey != Keys.LControlKey && boundKey != Keys.RControlKey)
                currState = GetAsyncKeyState(Keys.ControlKey) == 0 ? currState : KeyState.Up;
            else
                currState = controlMod != Keys.None && GetAsyncKeyState(controlMod) == 0 ? KeyState.Up : currState;

            if (shiftMod == Keys.None && boundKey != Keys.ShiftKey && boundKey != Keys.LShiftKey && boundKey != Keys.RShiftKey)
                currState = GetAsyncKeyState(Keys.ShiftKey) == 0 ? currState : KeyState.Up;
            else
                currState = shiftMod != Keys.None && GetAsyncKeyState(shiftMod) == 0 ? KeyState.Up : currState;

            if (altMod == Keys.None && boundKey != Keys.Menu && boundKey != Keys.LMenu && boundKey != Keys.RMenu)
                currState = GetAsyncKeyState(Keys.Menu) == 0 ? currState : KeyState.Up;
            else
                currState = altMod != Keys.None && GetAsyncKeyState(altMod) == 0 ? KeyState.Up : currState;

            currState = oldState == KeyState.HeldDown && currState == KeyState.Down ? KeyState.HeldDown : currState;

            bool reachedHeldDownTick = false;
            if (useHeldDown)
            {
                // Resets the down time if the key binds state was changed
                if (oldState != currState)
                {
                    currDownTime = 0;
                }
                // Increased the down time if the key binds state was not changed and is Down or HeldDown
                else if (currState == KeyState.Down || currState == KeyState.HeldDown)
                {
                    currDownTime += elapsedTime;
                }

                // Checks if the key was held down longh enaugh to change its state to 'HeldDown'
                if (currState == KeyState.Down && currDownTime >= heldDownTreshold)
                {
                    currDownTime = 0;
                    currState = KeyState.HeldDown;
                }

                // Checks if the key was held down long enaugh to trigger a tick
                if (currState == KeyState.HeldDown && currDownTime >= heldDownTickInterval)
                {
                    currDownTime = 0;
                    reachedHeldDownTick = true;
                }
            }

            return new KeyUpdateReport(currDownTime, oldState, currState, reachedHeldDownTick);
        }

        /// <summary>
        /// Enables the 'held down logic' for the key bind. Then the key bind can be Up, Down or HeldDown.
        /// Additionaly 'CurrDownTime' stores how long the key is Down or HeldDown.
        /// </summary>
        /// <param name="heldDownTreshold"> The time that (in ms) has to elapse to make the key bind enter the HeldDown state. Note that 0 is a valid value and results in the state never being Down but HeldDown! </param>
        /// <param name="heldDownTickInterval"> The frequenzy (in ms) at which a 'HeldDown-Tick' occures </param>
        public void EnableHeldDown(uint heldDownTreshold, uint heldDownTickInterval)
        {
            if(useHeldDown)
            {
                Console.WriteLine("EnableHeldDown was called while useHeldDown already was '" + useHeldDown + "'!");
                throw new InvalidOperationException("EnableHeldDown was called while useHeldDown already was '" + useHeldDown + "'!");
            }

            this.useHeldDown = true;
            this.currDownTime = 0;
            this.heldDownTreshold = heldDownTreshold;
            this.heldDownTickInterval = heldDownTickInterval;
        }

        /// <summary>
        /// Disables the 'held down logic' for the key bind. Then the key bind can only be Up or Down
        /// </summary>
        public void DisableHeldDown()
        {
            if (useHeldDown)
            {
                Console.WriteLine("DisableHeldDown was called while useHeldDown already was '" + useHeldDown + "'!");
                throw new InvalidOperationException("DisableHeldDown was called while useHeldDown already was '" + useHeldDown + "'!");
            }
            useHeldDown = false;
            currDownTime = 0;
            heldDownTreshold = 0;
            heldDownTickInterval = 0;
            currState = (currState == KeyState.HeldDown) ? KeyState.Down : currState;
        }

        public override bool Equals(Object other)
        {
            if (other == null)
                return false;

            if (!(other is KeyBind))
                return false;

            if (other == this)
                return true;

            KeyBind otherKeyBind = (KeyBind) other;

            if (otherKeyBind.BoundKey.Equals(this.BoundKey) && otherKeyBind.ControlMod.Equals(this.ControlMod)
                && otherKeyBind.ShiftMod.Equals(this.ShiftMod) && otherKeyBind.AltMod.Equals(this.AltMod))
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            int result = 17;
            result = 37 * result + BoundKey.GetHashCode();
            result = 37 * result + ControlMod.GetHashCode();
            result = 37 * result + ShiftMod.GetHashCode();
            result = 37 * result + AltMod.GetHashCode();
            return result;
        }

    }

    public class KeyUpdateReport
    {
        public readonly uint DownTime;
        public readonly KeyState OldState;
        public readonly KeyState NewState;
        public readonly bool KeyStateChanged;
        public readonly bool ReachedHeldDownTick;

        public KeyUpdateReport (uint downTime, KeyState oldState, KeyState newState, bool reachedHeldDownTick)
        {
            this.DownTime = downTime;
            this.OldState = oldState;
            this.NewState = newState;
            this.ReachedHeldDownTick = reachedHeldDownTick;
            this.KeyStateChanged = (OldState != NewState);
        }
    }
}
