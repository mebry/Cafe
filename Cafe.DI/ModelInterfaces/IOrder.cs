using Cafe.DI.DataInterfaces;

namespace Cafe.DI.ModelInterfaces
{
    public interface IOrder:IData<IPlatter>
    {
        int Id { get; }
        int TotalPrice { get; }
        DateTime Date { get; }
    }
}
