using Android.Bluetooth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppBLE.Platforms.Android.EventArgs
{
    public class CharacteristicReadCallbackEventArgs
    {
        public BluetoothGattCharacteristic Characteristic { get; }
        public GattStatus Status { get; }

        public CharacteristicReadCallbackEventArgs(BluetoothGattCharacteristic characteristic, GattStatus status)
        {
            Characteristic = characteristic;
            Status = status;
        }
    }
}
