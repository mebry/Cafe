using Newtonsoft.Json.Converters;
using Cafe.DI.Interfaces.Models;
using Cafe.DI.Enums;
using Cafe.Bll.Models.Request;

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
