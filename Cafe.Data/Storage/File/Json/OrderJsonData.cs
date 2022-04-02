using Newtonsoft.Json;
using Cafe.DI.Interfaces.Serialization;
using Cafe.DI.Interfaces.Models;
using Cafe.Data.Storage.Serialization;
using Cafe.Bll;

namespace Cafe.Data.Storage.Json
{
    /// <summary>
    /// A class for writing and reading data from a file by serialization and deserialization.
    /// </summary>
    public class OrderJsonData : ISerializationData<IOrder>
    {
        private List<IOrder> _orders;
        private string _path;

        /// <summary>
        /// Constructor for filling in data.
        /// </summary>
        /// <param name="path">The path where the file will be contained.</param>
        /// <param name="orders">List of elements.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public OrderJsonData(string path, List<IOrder> orders)
        {
            if (path == null)
                throw new ArgumentNullException(nameof(path));

            if (path == "")
                throw new ArgumentException(nameof(path));

            if (orders == null)
                throw new ArgumentNullException(nameof(orders));

            _orders = orders;
            _path = path;
        }

        public void Write()
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
