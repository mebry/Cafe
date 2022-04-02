using Newtonsoft.Json;

namespace Cafe.DI.SerializationInterfaces
{
    public interface ISerializationData<T>
    {
        void Read();
        void Restore(params JsonConverter[] jsonConverter);
        IEnumerable<T> GetAll();
    }
}
