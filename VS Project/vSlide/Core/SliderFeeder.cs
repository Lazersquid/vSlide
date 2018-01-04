using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Immutable;
using vJoyInterfaceWrap;

namespace vSlide
{
    public class SliderFeeder
    {
        #region fields & properties
        public const uint MaxDeviceId = 16;
        private vJoy vJoyDriver;

        public DriverState DriverState { get; }

        public FeederState State
        {
            get
            {
                if (DriverState != DriverState.Ok)
                    return FeederState.DriverError;
                if (OwnedDeviceId == 0)
                    return FeederState.NoVjoyDevice;

                return FeederState.Ready;
            }
        }

        private uint ownedDeviceId;
        public uint OwnedDeviceId
        {
            get { return ownedDeviceId; }

            private set
            {
                if (value > MaxDeviceId) throw new ArgumentOutOfRangeException();

                var isValueDifferent = ownedDeviceId != value;
                ownedDeviceId = value;

                if (isValueDifferent) OwnedDeviceIdChanged?.Invoke(this, null);
            }
        }

        private ImmutableArray<decimal> sliderLevels;
        public ImmutableArray<decimal> SliderLevels
        {
            get { return sliderLevels; }
            set
            {
                if (value == null) throw new ArgumentNullException();
                sliderLevels = value;
            }
        }

        private ImmutableArray<SliderManipulator> manipulators;
        public ImmutableArray<SliderManipulator> Manipulators
        {
            get { return manipulators; }
            set
            {
                if (value == null) throw new ArgumentNullException();
                manipulators = value;
            }
        }

        private const int defaultMaxSliderValue = 32767;
        private int maxSliderValue;
        public int MaxSliderValue
        {
            get { return maxSliderValue == 0 ? defaultMaxSliderValue : maxSliderValue; }
        }

        private int sliderValueAbs;
        public int SliderValueAbs
        {
            get { return sliderValueAbs; }
            
            private set
            {
                if (State != FeederState.Ready) throw new InvalidFeederOperationException(State);

                value = Math.Max(value, 0);
                value = Math.Min(value, MaxSliderValue);

                var isValueDifferent = sliderValueAbs != value;
                vJoyDriver.SetAxis(value, ownedDeviceId, HID_USAGES.HID_USAGE_SL0);
                sliderValueAbs = value;

                if(isValueDifferent) SliderValueChanged?.Invoke(this, null);
            }
        }

        public decimal SliderValue
        {
            get { return decimal.Divide(SliderValueAbs, MaxSliderValue); }

            set
            {
                value = Math.Max(value, 0);
                value = Math.Min(value, 1);
                SliderValueAbs = (int)(value * MaxSliderValue);
            }
        }

        private ISliderMode sliderMode;
        public ISliderMode SliderMode
        {
            get { return sliderMode; }
            set
            {
                sliderMode = value ?? throw new ArgumentNullException();
            }
        }

        private readonly string vjoyDriverVersion = "-";
        public string VjoyDriverVersion
        {
            get { return vjoyDriverVersion; }
        }

        private readonly string vjoyDllVersion = "-";
        public string VjoyDllVersion
        {
            get { return vjoyDllVersion; }
        }
        #endregion

        public event EventHandler OwnedDeviceIdChanged;
        public event EventHandler SliderValueChanged;

        public SliderFeeder()
        {
            SliderLevels = ImmutableArray.Create<decimal>();
            Manipulators = ImmutableArray.Create<SliderManipulator>();
            sliderMode = new DefaultSliderMode();

            vJoyDriver = new vJoy();
            DriverState = DriverState.VJoyNotInstalled;

            // checks if vjoy driver is installed
            if (!vJoyDriver.vJoyEnabled()) return;
            DriverState = DriverState.VersionMissmatch;
            vjoyDriverVersion = vJoyDriver.GetvJoyVersion().ToString();

            // checks if vjoy wraper dll version matches version of vjoy driver 
            uint DllVer = 0, DrvVer = 0;
            var doesDriverMatch = vJoyDriver.DriverMatch(ref DllVer, ref DrvVer);
            vjoyDllVersion = DllVer.ToString();
            if (!doesDriverMatch) return;
            DriverState = DriverState.Ok;
        }

        #region methods

        public void Update(int elapsedMs)
        {
            if (State != FeederState.Ready)
                throw new InvalidFeederOperationException(State);
            
            var updateInfo = new UpdateInformation(elapsedMs, MaxSliderValue, SliderValueAbs, SliderLevels, sliderMode);
            foreach(var manipulator in manipulators)
            {
                manipulator.Execute(updateInfo);
            }
            sliderMode = updateInfo.SliderMode;
            sliderMode.Execute(updateInfo);
            SliderValueAbs = updateInfo.SliderValueAbs;
        }

        public void AcquireVjoyDevice()
        {
            if (State != FeederState.NoVjoyDevice)
                throw new InvalidFeederOperationException(State);

            var devices = GetAcquirableVjoyDevices();
            if (devices.Count <= 0) throw new VjoyDeviceException("No free vjoy device to acquire!");
            AcquireVjoyDevice(devices.First());
        }

        public void AcquireVjoyDevice(uint newDeviceId)
        {
            if (State != FeederState.NoVjoyDevice)
                throw new InvalidFeederOperationException(State);

            if (!IsDeviceAcquirable(newDeviceId)) throw new InvalidOperationException(string.Format(
                "Can't acquire vjoy device {0}: It's status is {1}!", newDeviceId, vJoyDriver.GetVJDStatus(newDeviceId)));

            // acquire new device
            vJoyDriver.AcquireVJD(newDeviceId);
            OwnedDeviceId = newDeviceId;
            
            long newMaxSliderValue = 0;
            vJoyDriver.GetVJDAxisMax(OwnedDeviceId, HID_USAGES.HID_USAGE_SL0, ref newMaxSliderValue);
            maxSliderValue = (int)newMaxSliderValue;
            SliderValue = 0;
        }

        protected void RelinquishVJoyDevice(uint deviceId)
        {
            if (State == FeederState.DriverError)
                throw new InvalidFeederOperationException(State);

            if (vJoyDriver.GetVJDStatus(deviceId) != VjdStat.VJD_STAT_OWN)
                throw new InvalidOperationException(string.Format(
                 "Can't relinquish vjoy device {0}: Device is not acquired!", deviceId));

            // set slider of device to center
            if (vJoyDriver.GetVJDAxisExist(deviceId, HID_USAGES.HID_USAGE_SL0))
            {
                long maxValue = 0;
                vJoyDriver.GetVJDAxisMax(deviceId, HID_USAGES.HID_USAGE_SL0, ref maxValue);
                int valueAtCenter = (int)(maxValue / 2);
                vJoyDriver.SetAxis(valueAtCenter, deviceId, HID_USAGES.HID_USAGE_SL0);
            }
            vJoyDriver.RelinquishVJD(deviceId);
            maxSliderValue = 0;

            if (deviceId == OwnedDeviceId) OwnedDeviceId = 0;
        }

        public void RelinquishVJoyDevice()
        {
            if (State != FeederState.Ready)
                throw new InvalidFeederOperationException(State);

            RelinquishVJoyDevice(OwnedDeviceId);
        }

        public void RelinquishOwnedVJoyDevices()
        {
            if (State == FeederState.DriverError)
                throw new InvalidFeederOperationException(State);

            // check all devices in case something went wrong and the feeder acquired other devices
            for (uint deviceId = 1; deviceId <= MaxDeviceId; deviceId++)
            {
                if (vJoyDriver.GetVJDStatus(deviceId) != VjdStat.VJD_STAT_OWN) continue;
                RelinquishVJoyDevice(deviceId);
            }
        }

        protected bool IsDeviceOwned(uint deviceId)
        {
            if (State == FeederState.DriverError)
                throw new InvalidFeederOperationException(State);

            return vJoyDriver.GetVJDStatus(deviceId) == VjdStat.VJD_STAT_OWN;
        }

        public bool HasDeviceSlider(uint deviceId)
        {
            if (State == FeederState.DriverError)
                throw new InvalidFeederOperationException(State);

            return vJoyDriver.GetVJDAxisExist(deviceId, HID_USAGES.HID_USAGE_SL0);
        }

        public bool IsDeviceAcquirable(uint deviceId)
        {
            if (State == FeederState.DriverError)
                throw new InvalidFeederOperationException(State);

            var status = vJoyDriver.GetVJDStatus(deviceId);
            return status == VjdStat.VJD_STAT_FREE && HasDeviceSlider(deviceId);
        }

        public ImmutableList<uint> GetAcquirableVjoyDevices()
        {
            if (State == FeederState.DriverError)
                throw new InvalidFeederOperationException(State);

            List<uint> availableJoystickIds = new List<uint>();
            for (uint deviceId = 1; deviceId <= MaxDeviceId; deviceId++)
            {
                if (!IsDeviceAcquirable(deviceId)) continue;
                availableJoystickIds.Add(deviceId);
            }

            return availableJoystickIds.ToImmutableList();
        }

        public DeviceState GetDeviceStatus(uint deviceId)
        {
            var status = vJoyDriver.GetVJDStatus(deviceId);
            return VjdStatToDeviceStat(status);
        }

        protected DeviceState VjdStatToDeviceStat(VjdStat vjdStat)
        {
            switch (vjdStat)
            {
                case VjdStat.VJD_STAT_FREE:
                    return DeviceState.Free;

                case VjdStat.VJD_STAT_BUSY:
                    return DeviceState.Busy;

                case VjdStat.VJD_STAT_MISS:
                    return DeviceState.Missing;

                case VjdStat.VJD_STAT_OWN:
                    return DeviceState.Acquired;

                default:
                    return DeviceState.Unknown;
            }
        }
        #endregion
    }
}

public enum DriverState
{
    VJoyNotInstalled,
    VersionMissmatch,
    Ok
}

public enum FeederState
{
    DriverError,
    NoVjoyDevice,
    Ready
}

public enum DeviceState
{
    Unknown,
    Missing,
    Busy,
    Acquired,
    Free
}
