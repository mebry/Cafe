using Newtonsoft.Json.Converters;
using Cafe.DI.Interfaces.Models;
using Cafe.Bll.Models.Request;

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
