using Cafe.DI.Enums;
using Cafe.DI.ModelInterfaces;

namespace Cafe.DI.OperationInterfaces.Find
{
    public interface IFindOrders 
    {
        IEnumerable<IOrder> FindByRange(TypeOfProduct typeOfProduct, DateTime start, DateTime end);
        IEnumerable<Tuple<IIngredient, int>> FindMinUsedIngredients();
        IEnumerable<Tuple<IIngredient, int>> FindMaxUsedIngredients();
    }
}
