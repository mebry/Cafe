using Cafe.DI.ModelInterfaces;

namespace Cafe.DI.UserInterfaces
{
    public interface IManager:IPerson
    {
        int CalculationPrice(IOrder order);
        IOrder CreateOrder(IPlatter platter);
    }
}
