using Cafe.DI.DataInterfaces;

namespace Cafe.DI.ModelInterfaces
{
    /// <summary>
    /// The interface responsible for ordering dishes.
    /// </summary>
    public interface IOrder:IData<IPlatter>
    {
        int Id { get; }
        int TotalPrice { get; }
        DateTime Date { get; }
    }
}
