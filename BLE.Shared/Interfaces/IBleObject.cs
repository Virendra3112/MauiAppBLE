namespace BLE.Shared.Interfaces
{
    public interface IBleObject : IDisposable
    {
        string Name { get; }
        string Description { get; }

        Guid Guid { get; }
    }
}
