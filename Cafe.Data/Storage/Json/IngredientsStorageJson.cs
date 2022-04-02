using Newtonsoft.Json;
using Cafe.DI.SerializationInterfaces;
using Cafe.DI.ModelInterfaces;
using Cafe.Data.Storage.Serialization;
using Cafe.Bll;

namespace Cafe.Data.Storage.Json
{
    public class IngredientsStorageJson : ISerializationData<IIngredientsStorage>
    {
        [JsonIgnore]
        private List<IIngredientsStorage> _ingredientsStorage;
        private string _path;

        public IngredientsStorageJson(string path, List<IIngredientsStorage> ingredientsStorage)
        {
            _ingredientsStorage = ingredientsStorage;
            _path = path;
        }

        public void Read()
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
