using Newtonsoft.Json;
using Cafe.DI.SerializationInterfaces;
using Cafe.DI.ModelInterfaces;
using Cafe.Data.Storage.Serialization;
using Cafe.Bll;

namespace Cafe.Data.Storage.Json
{
    public class OrderJsonData : ISerializationData<IOrder>
    {
        [JsonIgnore]
        private List<IOrder> _orders;
        private string _path;

        public OrderJsonData(string path, List<IOrder> orders)
        {
            _orders = orders;
            _path = path;
        }

        public void Read()
        {
            SerializeObject.Serialize<IOrder>(_path, _orders);
        }

        public void Restore(params JsonConverter[] jsonConverter)
        {
            _orders=DeserializeObject.Deserialize<IOrder>(_path, jsonConverter).ToList();
        }

        public IEnumerable<IOrder> GetAll() => _orders;
    }
}
