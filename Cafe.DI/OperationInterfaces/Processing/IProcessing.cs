using Cafe.DI.Enums;

namespace Cafe.DI.OperationInterfaces.Processing
{
    public interface IProcessing
    {
        ProcessingType Operation { get; set; }
        int Price { get; }

        void Execute();
    }
}
