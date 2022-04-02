namespace Cafe.DI.ModelInterfaces
{
    /// <summary>
    /// Storage conditions.
    /// </summary>
    public interface IStorageConditions
    {
        int MinTemperature { get; }
        int MaxTemperature { get; }
    }
}
