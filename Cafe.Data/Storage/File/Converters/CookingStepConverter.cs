using Newtonsoft.Json.Converters;
using Cafe.DI.Interfaces.Models;
using Cafe.DI.Interfaces.Recipe;
using Cafe.DI.Enums;
using Cafe.Bll.Models;

namespace Cafe.Data.Storage.Converters
{
    public class CookingStepConverter : CustomCreationConverter<ICookingStep>
    {
        public override ICookingStep Create(Type objectType)
        {
            return new CookingStep((ProcessingType.NoProcessing, TimeSpan.Zero), 
                new List<(IIngredient, int)>(), TimeSpan.Zero);
        }
    }
}
