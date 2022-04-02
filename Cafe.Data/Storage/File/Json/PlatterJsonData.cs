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
    public class PlatterJsonData : ISerializationData<IPlatter>
    {
        private List<IPlatter> _platters;
        private string _path;

        /// <summary>
        /// Constructor for filling in data.
        /// </summary>
        /// <param name="path">The path where the file will be contained.</param>
        /// <param name="platters">List of elements.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public PlatterJsonData(string path, List<IPlatter> platters)
        {
            if (path == null)
                throw new ArgumentNullException(nameof(path));

            if (path == "")
                throw new ArgumentException(nameof(path));

            if (platters == null)
                throw new ArgumentNullException(nameof(platters));

            _platters = platters;
            _path = path;
        }

        /// <summary>
        /// The method responsible for writing the data.
        /// </summary>
        public void Write()
        {
            SerializeObject.Serialize<IPlatter>(_path, _platters);
        }

        /// <summary>
        /// The method responsible for reading the data.
        /// </summary>
        /// <param name="jsonConverter"></param>
        public void Restore(params JsonConverter[] jsonConverter)
        {
            _platters = DeserializeObject.Deserialize<IPlatter>(_path, jsonConverter).ToList();
        }

        public IEnumerable<IPlatter> GetAll() => _platters;
    }
}
