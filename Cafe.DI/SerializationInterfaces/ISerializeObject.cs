

namespace Cafe.DI.SerializationInterfaces
{
    public interface ISerializeObject
    {
        void Serialize<T>(IEnumerable<T> data);
    }
}
