namespace BLE.Shared.Interfaces
{
    public interface IBLEService
    {
        IList<ICharacteristics> GetCharacteristics { get; }

        IDevice device { get; }

        Task<bool> DiscoverChars();
    }
}
