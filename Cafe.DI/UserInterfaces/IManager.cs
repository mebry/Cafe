using Cafe.DI.ModelInterfaces;

namespace Cafe.DI.UserInterfaces
{
    /// <summary>
    /// Interface describing the behavior of the manager.
    /// </summary>
    public interface IManager:IPerson
    {
        int CalculationPrice(IMeal meals);
        IOrder CreateOrder(IMeal meals);
    }
}
