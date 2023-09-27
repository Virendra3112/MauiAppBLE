namespace BLE.Shared.Interfaces
{
    public interface IAdapter : IBleObject
    {
        string AdapterState { get; }

        event EventHandler AdapterStateChanged;

        Task<bool> ConnectBLEDevice(IDevice device);

        Task DisConnectBLEDevice(IDevice device);

        Task CancelPendingConnections();

        IDevice GetDeviceByUID(string uuid);
    }
}
