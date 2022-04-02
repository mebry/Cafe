using Newtonsoft.Json;
using Cafe.DI.SerializationInterfaces;

namespace Cafe.Data.Storage.Serialization
{
    /// <summary>
    /// The class responsible for deserialization.
    /// </summary>
    public class DeserializeObject 
    {/*
        /// <summary>
        /// Constructor for filling the path.
        /// </summary>
        /// <param name="path"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public DeserializeObject(string path)
        {
            if (path == null)
                throw new ArgumentNullException(nameof(path));

            if (path.Length == 0)
                throw new ArgumentException(nameof(path));

            _path = path;
        }*/

        /// <summary>
        /// The method responsible for deserialization.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonConverter"></param>
        /// <returns></returns>
        public static IEnumerable<T> Deserialize<T>(string path, params JsonConverter[] jsonConverters)
        {
            JsonSerializer serializer = new JsonSerializer();
            IEnumerable<T> data;
            using (StreamReader reader = new StreamReader(path))
            {
                string str = reader.ReadToEnd();
                data = JsonConvert.DeserializeObject<IEnumerable<T>>(str, jsonConverters);
            }
            return data;
        }
    }
}
