using Newtonsoft.Json.Converters;
using Cafe.DI.Interfaces.Models;
using Cafe.DI.Enums;
using Cafe.Bll.Models.Warehouse;
using Cafe.Bll.Models.Prescription;

namespace Cafe.Data.Storage.Converters
{
    public class IngredientConverter : CustomCreationConverter<IIngredient>
    {
        public override IIngredient Create(Type objectType)
        {
            return new Ingredient(1,TypeOfIngredient.Water,new Conditions(-1,1));
        }
    }
}
