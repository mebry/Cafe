using Newtonsoft.Json;
using Cafe.DI.SerializationInterfaces;
using Cafe.DI.ModelInterfaces;
using Cafe.Data.Storage.Serialization;
using Cafe.Bll;

namespace Cafe.Data.Storage.Json
{
    /// <summary>
    /// A class for writing and reading data from a file by serialization and deserialization.
    /// </summary>
    public class IngredientsStorageJson : ISerializationData<IIngredientsStorage>
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
        public IngredientsStorageJson(string path, List<IIngredientsStorage> ingredientsStorage)
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

        public void Write()
        {
            SerializeObject.Serialize<IIngredientsStorage>(_path, _ingredientsStorage);
        }

        public void Restore(params JsonConverter[] jsonConverter)
        {
            _ingredientsStorage = DeserializeObject.Deserialize<IIngredientsStorage>(_path, jsonConverter).ToList();
        }

        public IEnumerable<IIngredientsStorage> GetAll() => _ingredientsStorage;
    }
}
