using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLE.Shared.Interfaces
{
    public interface IScanner : IBleObject
    {
        bool IsScanning { get; }

        void StartScan();
        void StartScan(Guid[] guids = null);

        void StopScan();
        void TimeoutScan();

        void ReDiscoverDevices(IDevice device);

        event EventHandler DevicesDiscovered;
        event EventHandler ScanTimeout;
    }
}
