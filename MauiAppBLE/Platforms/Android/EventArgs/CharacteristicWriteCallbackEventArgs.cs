using Android.Bluetooth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppBLE.Platforms.Android.EventArgs
{
    public class CharacteristicWriteCallbackEventArgs
    {
        public BluetoothGattCharacteristic Characteristic { get; }
        public Exception Exception { get; }
        public GattStatus Status { get; }

        public CharacteristicWriteCallbackEventArgs(BluetoothGattCharacteristic characteristic, GattStatus status, Exception exception = null)
        {
            Characteristic = characteristic;
            Status = status;
            Exception = exception;
        }
    }
}
