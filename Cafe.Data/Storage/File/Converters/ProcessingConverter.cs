using Newtonsoft.Json.Converters;
using Cafe.DI.Interfaces.Operation.Processing;
using Cafe.DI.Enums;
using Cafe.Bll.Models;

namespace Cafe.Data.Storage.Converters
{
    public class ProcessingConverter : CustomCreationConverter<IProcessing>
    {
        public override IProcessing Create(Type objectType)
        {
            return new Processing(1, new TimeSpan(0, 0, 1),ProcessingType.NoProcessing);
        }
    }
}
