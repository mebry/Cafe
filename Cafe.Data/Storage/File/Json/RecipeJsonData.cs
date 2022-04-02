using Newtonsoft.Json;
using Cafe.DI.Interfaces.Serialization;
using Cafe.DI.Interfaces.Models;
using Cafe.Data.Storage.Serialization;
using Cafe.DI.Interfaces.Recipe;

namespace Cafe.Data.Storage.Json
{
    /// <summary>
    /// A class for writing and reading data from a file by serialization and deserialization.
    /// </summary>
    public class RecipeJsonData : ISerializationData<IRecipe>
    {
        private List<IRecipe> _recipes;
        private string _path;

        /// <summary>
        /// Constructor for filling in data.
        /// </summary>
        /// <param name="path">The path where the file will be contained.</param>
        /// <param name="platters">List of elements.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public RecipeJsonData(string path, List<IRecipe> recipes)
        {
            if (path == null)
                throw new ArgumentNullException(nameof(path));

            if (path == "")
                throw new ArgumentException(nameof(path));

            if (recipes == null)
                throw new ArgumentNullException(nameof(recipes));

            _recipes = recipes;
            _path = path;
        }

        /// <summary>
        /// The method responsible for writing the data.
        /// </summary>
        public void Write()
        {
            SerializeObject.Serialize<IRecipe>(_path, _recipes);
        }

        /// <summary>
        /// The method responsible for reading the data.
        /// </summary>
        /// <param name="jsonConverter"></param>
        public void Restore(params JsonConverter[] jsonConverter)
        {
            _recipes = DeserializeObject.Deserialize<IRecipe>(_path, jsonConverter).ToList();
        }

        public IEnumerable<IRecipe> GetAll() => _recipes;
    }
}
