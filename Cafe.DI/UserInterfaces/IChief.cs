using Cafe.DI.ModelInterfaces;
using Cafe.DI.RecipeInterfaces;

namespace Cafe.DI.UserInterfaces
{
    /// <summary>
    /// Interface describing the behavior of the chef.
    /// </summary>
    public interface IChief: IPerson
    {
        void ExecuteOrder(IOrder order);
        void CreateRecipe(IProduct product);
    }
}
