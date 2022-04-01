using Newtonsoft.Json;

namespace Cafe.DI.SerializationInterfaces
{
    public interface IDeserializeObject
    {
        IEnumerable<T> Deserialize<T>(JsonConverter jsonConverter);
    }
}
