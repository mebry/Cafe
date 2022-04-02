using Newtonsoft.Json.Converters;
using Cafe.DI.ModelInterfaces;
using Cafe.DI.Enums;
using Cafe.Bll;

namespace Cafe.Data.Storage.Converters
{
    public class PlatterConverter : CustomCreationConverter<IPlatter>
    {
        public override IPlatter Create(Type objectType)
        {
            return new Platter(TypeOfProduct.Dish, "NoN", 10);
        }
    }
}
