using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLE.Shared.Interfaces
{
    public interface IBleObject
    {
        string Name { get; }
        string Description { get; }

        Guid Guid { get; }
    }
}
