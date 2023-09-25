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

        void StopScan();
    }
}
