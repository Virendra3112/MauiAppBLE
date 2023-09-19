using Android.Bluetooth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppBLE.Platforms.Android.EventArgs
{
    public class DescriptorCallbackEventArgs
    {
        public BluetoothGattDescriptor Descriptor { get; }
        public Exception Exception { get; }

        public DescriptorCallbackEventArgs(BluetoothGattDescriptor descriptor, Exception exception = null)
        {
            Descriptor = descriptor;
            Exception = exception;
        }
    }
}
