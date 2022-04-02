using Newtonsoft.Json.Converters;
using Cafe.DI.ModelInterfaces;
using Cafe.DI.Enums;
using Cafe.Bll;

namespace Cafe.Data.Storage.Converters
{
    public class IngredientsStorageConverter : CustomCreationConverter<IIngredientsStorage>
    {
        public override IIngredientsStorage Create(Type objectType)
        {
            return new IngredientsStorage(new List<(IIngredient, int)>(),1,1, new Conditions(-1, 1));
        }
    }
}
