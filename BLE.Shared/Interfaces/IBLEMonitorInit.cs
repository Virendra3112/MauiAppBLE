namespace BLE.Shared.Interfaces
{
    public interface IBLEMonitorInit : IDisposable
    {
        void onInit();

        void Clean();

        bool IsInit { get; }
    }
}
