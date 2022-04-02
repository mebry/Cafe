using Newtonsoft.Json;

namespace Cafe.DI.SerializationInterfaces
{
    /// <summary>
    /// An interface describing a contract that implements data deserialization.
    /// </summary>
    public interface IDeserialize
    {
        void Restore(params JsonConverter[] jsonConverter);
    }
}
