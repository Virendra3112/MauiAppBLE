using Android.Bluetooth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppBLE.Platforms.Android.Helpers
{
    public static class BluetoothStateExtension
    {
        public static BluetoothState ToBluetoothState(this State state)
        {
            switch (state)
            {
                case State.Connected:
                case State.Connecting:
                case State.Disconnected:
                case State.Disconnecting:
                    return BluetoothState.On;
                case State.Off:
                    return BluetoothState.Off;
                case State.On:
                    return BluetoothState.On;
                case State.TurningOff:
                    return BluetoothState.TurningOff;
                case State.TurningOn:
                    return BluetoothState.TurningOn;
                default:
                    return BluetoothState.Unknown;
            }
        }
    }


    public class BluetoothState
    {
        public static BluetoothState On { get; internal set; }
        public static BluetoothState Off { get; internal set; }
        public static BluetoothState TurningOff { get; internal set; }
        public static BluetoothState TurningOn { get; internal set; }
        public static BluetoothState Unknown { get; internal set; }
    }
}
