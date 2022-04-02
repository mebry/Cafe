using Cafe.DI.Enums;

namespace Cafe.DI.ModelInterfaces
{
    /// <summary>
    /// The type of dish and its cost.
    /// </summary>
    public interface IPlatter
    {
        TypeOfProduct TypeOfProduct { get; }
        string Name { get; }
        int Price { get; }
    }
}
