using Newtonsoft.Json.Converters;
using Cafe.DI.ModelInterfaces;
using Cafe.DI.Enums;
using Cafe.Bll;

namespace Cafe.Data.Storage.Converters
{
    public class OrderConverter : CustomCreationConverter<IOrder>
    {
        public override IOrder Create(Type objectType)
        {
            return new Order(1,DateTime.Now, new List<IPlatter>());
        }
    }
}
