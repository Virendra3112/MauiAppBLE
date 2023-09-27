namespace BLE.Shared.Interfaces
{
    public interface ICharacteristics : IBleObject
    {
        bool CanRead { get; }
        bool CanWrite { get; }
        bool CanNotify { get; }

        bool CanNotifyAll { get; }

        IBLEService bLEService { get; }

        byte[] Value { get; }

        Task<bool> Read();

        Task<bool> Notify();
        Task<bool> Write(byte[] value);

        void Write2(byte[] value);

        event EventHandler Notified;



    }
}
