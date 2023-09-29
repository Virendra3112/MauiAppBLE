using BLE.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLE.Shared.Implementations
{
    public class Adapter : IAdapter
    {
        public string AdapterState => throw new NotImplementedException();

        public string Name => throw new NotImplementedException();

        public string Description => throw new NotImplementedException();

        public Guid Guid => throw new NotImplementedException();

        public event EventHandler AdapterStateChanged;

        public Task CancelPendingConnections()
        {
            throw new NotImplementedException();
        }

        public Task<bool> ConnectBLEDevice(IDevice device)
        {
            throw new NotImplementedException();
        }

        public Task DisConnectBLEDevice(IDevice device)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IDevice GetDeviceByUID(string uuid)
        {
            throw new NotImplementedException();
        }
    }
}
