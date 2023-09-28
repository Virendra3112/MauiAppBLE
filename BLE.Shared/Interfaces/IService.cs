namespace BLE.Shared.Interfaces
{
    public interface IBLEService : IDisposable
    {
        IList<ICharacteristics> GetCharacteristics { get; }

        IDevice device { get; }

        Task<bool> DiscoverChars();
    }
}
