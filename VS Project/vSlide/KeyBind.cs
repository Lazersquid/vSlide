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
                    Console.WriteLine("Tried to set 'ControlMod' to '" + value + "'!");
                    throw new ArgumentException("Tried to set 'ControlMod' to '" + value + "'!");
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

                altMod = value;
                currState = KeyState.Up;
                currDownTime = 0;
            }
        }
        private KeyState currState;
        public KeyState CurrState
        {
            get { return currState; }
        }
        private bool useHeldDown;
        public bool UseHeldDown
        {
            get { return useHeldDown; }
        }
        private uint currDownTime;
        public uint CurrDownTime
        {
            get { return currDownTime; }
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

        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(Keys vKey);

        public KeyUpdateReport UpdateKey(uint elapsedTime)
        {
            KeyState oldState = currState;
            currState = GetAsyncKeyState(BoundKey) == 0 ? KeyState.Up : KeyState.Down;
            currState = controlMod != Keys.None && GetAsyncKeyState(controlMod) == 0 ? KeyState.Up : currState;
            currState = shiftMod != Keys.None && GetAsyncKeyState(shiftMod) == 0 ? KeyState.Up : currState;
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
                if(currState == KeyState.HeldDown && currDownTime >= heldDownTickInterval)
                {
                    currDownTime = 0;
                    reachedHeldDownTick = true;
                }
            }

            return new KeyUpdateReport(currDownTime, oldState, currState, reachedHeldDownTick);
        }

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
