using Cafe.DI.Interfaces.Models;
using Cafe.DI.Interfaces.Recipe;

namespace Cafe.DI.UserInterfaces
{
    /// <summary>
    /// Interface describing the behavior of the chef.
    /// </summary>
    public interface IChief: IPerson
    {
        void ExecuteOrder(IOrder order);
        void CreateRecipe(IRecipe product);
    }
}
