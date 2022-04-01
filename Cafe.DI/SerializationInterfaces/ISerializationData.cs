using Newtonsoft.Json;

namespace Cafe.DI.SerializationInterfaces
{
    public interface ISerializationData
    {
        void Read<T>(IEnumerable<T> data);
        IEnumerable<T> Restore<T>(JsonConverter jsonConverter, IDeserializeObject deserialize);
    }
}
