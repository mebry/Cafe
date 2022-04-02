using Cafe.DI.Enums;
using Cafe.DI.Interfaces.Models;

namespace Cafe.DI.Interfaces.Recipe
{
    /// <summary>
    /// Interface describing the finished recipe.
    /// </summary>
    public interface IProduct
    {
        int TotalPrice { get; }
        string Name { get; }
        TypeOfProduct TypeOfProduct { get; }
        List<ICookingStep> CookingSteps { get; }
        List<Tuple<IIngredient, int>> Ingredients { get; }  
    }
}



