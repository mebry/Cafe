using Newtonsoft.Json;
using Cafe.DI.ModelInterfaces;

namespace Cafe.Bll
{
    /// <summary>
    /// The class responsible for storing the temperature range.
    /// </summary>
    public class Conditions : IStorageConditions
    {
        /// <summary>
        /// Constructor for filling in data.
        /// </summary>
        /// <param name="minTemperature"></param>
        /// <param name="maxTemperature"></param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Conditions(int minTemperature, int maxTemperature)
        {
            if (minTemperature > maxTemperature)
                throw new ArgumentException(nameof(minTemperature));

            if (maxTemperature < minTemperature)
                throw new ArgumentException(nameof(maxTemperature));

            if (minTemperature < -40)
                throw new ArgumentOutOfRangeException(nameof(minTemperature));

            if (maxTemperature > 100)
                throw new ArgumentOutOfRangeException(nameof(maxTemperature));

            MinTemperature = minTemperature;
            MaxTemperature = maxTemperature;
        }

        [JsonProperty(PropertyName = "MinTemperature")]
        public int MinTemperature { get; }

        [JsonProperty(PropertyName = "MaxTemperature")]
        public int MaxTemperature { get; }
    }
}
