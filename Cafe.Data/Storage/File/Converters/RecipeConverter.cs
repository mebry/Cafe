using Newtonsoft.Json.Converters;
using Cafe.DI.Interfaces.Models;
using Cafe.DI.Interfaces.Recipe;
using Cafe.DI.Enums;
using Cafe.Bll.Models;

namespace Cafe.Data.Storage.Converters
{
    public class RecipeConverter : CustomCreationConverter<IRecipe>
    {
        public override IRecipe Create(Type objectType)
        {
            return new Recipe(1, "NoN", TypeOfProduct.Dish,
                new List<ICookingStep>(), new List<(IIngredient, int)>());
        }
    }
}
