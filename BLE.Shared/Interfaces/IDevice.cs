using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLE.Shared.Interfaces
{
    public interface IDevice : IBleObject
    {
        IAdapter Adapter { get; }

        Task<bool> Connect();
        Task<bool> Disconnect();
    }
}
