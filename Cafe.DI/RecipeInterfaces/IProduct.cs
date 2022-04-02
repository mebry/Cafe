using Cafe.DI.Enums;
using Cafe.DI.ModelInterfaces;

namespace Cafe.DI.RecipeInterfaces
{
    public interface IProduct
    {
        int TotalPrice { get; }
        string Name { get; }
        TypeOfProduct TypeOfProduct { get; }
        List<ICookingStep> CookingSteps { get; }
        List<Tuple<IIngredient, int>> Ingredients { get; }  
    }
}



