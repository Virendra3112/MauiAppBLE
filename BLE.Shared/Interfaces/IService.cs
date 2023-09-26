using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLE.Shared.Interfaces
{
    public interface IBLEService
    {
        IList<ICharacteristics> GetCharacteristics { get; }

        IDevice device { get; }

        Task<bool> DiscoverChars();
    }
}
