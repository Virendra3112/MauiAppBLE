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
