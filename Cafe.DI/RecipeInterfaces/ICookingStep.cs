using Cafe.DI.Enums;

namespace Cafe.DI.RecipeInterfaces
{
    public interface ICookingStep
    {
        Tuple<ProcessingType, TimeSpan> Type { get; }
        List<Tuple<IIngredient, int>> Ingredients { get; }
        TimeSpan TimeSpan { get; }
    }
}
        