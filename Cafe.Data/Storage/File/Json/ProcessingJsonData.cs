using Newtonsoft.Json;
using Cafe.DI.Interfaces.Serialization;
using Cafe.Data.Storage.Serialization;
using Cafe.DI.Interfaces.Operation.Processing;

namespace Cafe.Data.Storage.Json
{
    /// <summary>
    /// A class for writing and reading data from a file by serialization and deserialization.
    /// </summary>
    public class ProcessingJsonData : ISerializationData<IProcessing>
    {
        private List<IProcessing> _processings;
        private string _path;

        /// <summary>
        /// Constructor for filling in data.
        /// </summary>
        /// <param name="path">The path where the file will be contained.</param>
        /// <param name="platters">List of elements.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public ProcessingJsonData(string path, List<IProcessing> processing)
        {
            if (path == null)
                throw new ArgumentNullException(nameof(path));

            if (path == "")
                throw new ArgumentException(nameof(path));

            if (processing == null)
                throw new ArgumentNullException(nameof(processing));

            _processings = processing;
            _path = path;
        }

        /// <summary>
        /// The method responsible for writing the data.
        /// </summary>
        public void Write()
        {
            SerializeObject.Serialize<IProcessing>(_path, _processings);
        }

        /// <summary>
        /// The method responsible for reading the data.
        /// </summary>
        /// <param name="jsonConverter"></param>
        public void Restore(params JsonConverter[] jsonConverter)
        {
            _processings = DeserializeObject.Deserialize<IProcessing>(_path, jsonConverter).ToList();
        }

        /// <summary>
        /// A method that returns a set of elements.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IProcessing> GetAll() => _processings;
    }
}
