using Android.Bluetooth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppBLE.Platforms.Android
{
    internal class Adapter
    {
        private readonly BluetoothManager _bluetoothManager;
        private readonly BluetoothAdapter _bluetoothAdapter;

        private readonly Dictionary<string, TaskCompletionSource<bool>> _bondingTcsForAddress = new();

        public Adapter(BluetoothManager bluetoothManager)
        {
            _bluetoothManager = bluetoothManager;
            _bluetoothAdapter = bluetoothManager.Adapter;


        }
    }
}
