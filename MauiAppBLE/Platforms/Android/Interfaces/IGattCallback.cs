using MauiAppBLE.Platforms.Android.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppBLE.Platforms.Android.Interfaces
{
    public interface IGattCallback
    {
        event EventHandler<ServicesDiscoveredCallbackEventArgs> ServicesDiscovered;
        event EventHandler<CharacteristicReadCallbackEventArgs> CharacteristicValueRead;
        event EventHandler<CharacteristicReadCallbackEventArgs> CharacteristicValueUpdated;
        event EventHandler<CharacteristicWriteCallbackEventArgs> CharacteristicValueWritten;
        event EventHandler<DescriptorCallbackEventArgs> DescriptorValueWritten;
        event EventHandler<DescriptorCallbackEventArgs> DescriptorValueRead;
        event EventHandler<RssiReadCallbackEventArgs> RemoteRssiRead;
        event EventHandler ConnectionInterrupted;
        event EventHandler<MtuRequestCallbackEventArgs> MtuRequested;
    }
}
