using Newtonsoft.Json;
using Cafe.DI.SerializationInterfaces;

namespace Cafe.Data.Storage.Serialization
{
    /// <summary>
    /// The class responsible for serialization.
    /// </summary>
    public class SerializeObject /*: ISerializeObject*/
    {
        /*private readonly string _path;

        /// <summary>
        /// Constructor for filling the path.
        /// </summary>
        /// <param name="path"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public SerializeObject(string path)
        {
            if (path == null)
                throw new ArgumentNullException(nameof(path));

            if (path.Length == 0)
                throw new ArgumentException(nameof(path));

            _path = path;
        }*/

        /// <summary>
        /// The method responsible for serialization.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        public static void Serialize<T>(string path, IEnumerable<T> data)
        {
            JsonSerializer serializer = new JsonSerializer();

            string str = JsonConvert.SerializeObject(data);

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLine(str);
            }
        }
    }
}
