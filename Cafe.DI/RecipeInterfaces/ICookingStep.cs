using Cafe.DI.Enums;
using Cafe.DI.ModelInterfaces;

namespace Cafe.DI.RecipeInterfaces
{
    /// <summary>
    /// Interface describing the cooking step of the dish.
    /// </summary>
    public interface ICookingStep
    {
        Tuple<ProcessingType, TimeSpan> Type { get; }
        List<Tuple<IIngredient, int>> Ingredients { get; }
        TimeSpan TimeSpan { get; }
    }
}
        