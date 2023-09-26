using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLE.Shared.Interfaces
{
    public interface IBLEMonitorInit : IDisposable
    {
        void onInit();

        void Clean();

        bool IsInit { get; }
    }
}
