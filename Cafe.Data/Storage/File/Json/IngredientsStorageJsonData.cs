using Newtonsoft.Json;
using Cafe.DI.Interfaces.Serialization;
using Cafe.DI.Interfaces.Models;
using Cafe.Data.Storage.Serialization;

namespace Cafe.Data.Storage.Json
{
    /// <summary>
    /// A class for writing and reading data from a file by serialization and deserialization.
    /// </summary>
    public class IngredientsStorageJsonData : ISerializationData<IIngredientsStorage>
    {
        private List<IIngredientsStorage> _ingredientsStorage;
        private string _path;

        /// <summary>
        /// Constructor for filling in data.
        /// </summary>
        /// <param name="path">The path where the file will be contained.</param>
        /// <param name="ingredientsStorage">List of elements.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public IngredientsStorageJsonData(string path, List<IIngredientsStorage> ingredientsStorage)
        {
            if(path==null)
                throw new ArgumentNullException(nameof(path));

            if (path == "")
                throw new ArgumentException(nameof(path));

            if(ingredientsStorage==null)
                throw new ArgumentNullException(nameof(ingredientsStorage));

            _ingredientsStorage = ingredientsStorage;
            _path = path;
        }

        /// <summary>
        /// The method responsible for writing the data.
        /// </summary>
        public void Write()
        {
            SerializeObject.Serialize<IIngredientsStorage>(_path, _ingredientsStorage);
        }

        /// <summary>
        /// The method responsible for reading the data.
        /// </summary>
        /// <param name="jsonConverter"></param>
        public void Restore(params JsonConverter[] jsonConverter)
        {
            _ingredientsStorage = DeserializeObject.Deserialize<IIngredientsStorage>(_path, jsonConverter).ToList();
        }

        /// <summary>
        /// A method that returns a set of elements.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IIngredientsStorage> GetAll() => _ingredientsStorage;
    }
}
