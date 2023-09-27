namespace BLE.Shared.Interfaces
{
    public interface IDevice : IBleObject
    { 
        IAdapter Adapter { get; }

        Task<bool> Connect();
        Task<bool> Disconnect();

        IList<IBLEService> Services { get; }

        string BLEDeviceStates { get; }
        string BLEReconnectId { get; }

        Task<bool> DiscoverServices(Guid[] guids);


    }
}
