using Cafe.DI.ModelInterfaces;

namespace Cafe.DI.UserInterfaces
{
    public interface IClient: IPerson
    {
        int Id { get; }
        int Balance { get; }

        void PutMoney(int amount);
        IOrder CreateOrder(List<IPlatter> platters);
    }
}
