﻿using Snowflake.Input.Device;
using Snowflake.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snowflake.Input.Tests
{
    public class TestDeviceEnumerator : IDeviceEnumerator
    {
        public IEnumerable<IInputDevice> QueryConnectedDevices()
        {
            yield return new InputDevice(IDeviceEnumerator.VirtualVendorID,
               IDeviceEnumerator.PassthroughDevicePID,
               "Passthrough", "Emulator Handled", "passthrough", IDeviceEnumerator.PassthroughInstanceGuid,
               new List<IInputDeviceInstance>() { new PassthroughDeviceInstance() });

            yield return new InputDevice(IDeviceEnumerator.VirtualVendorID,
             IDeviceEnumerator.KeyboardDevicePID, "Keyboard",
             "Keyboard and Mouse", "keyboard", IDeviceEnumerator.KeyboardInstanceGuid,
             new List<IInputDeviceInstance>() { new KeyboardDeviceInstance() });

            yield return new InputDevice(IDeviceEnumerator.VirtualVendorID,
                0x01, "Test Device", "Test Device", "test", Guid.Empty,
                new List<IInputDeviceInstance>() { new XInputDeviceInstance(0) });
        }
    }
}
