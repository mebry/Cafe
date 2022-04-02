using Cafe.DI.OperationInterfaces.Processing;

namespace Cafe.DI.OperationInterfaces.Find
{
    /// <summary>
    /// Interface describing the main types of search.
    /// </summary>
    public interface IFindProcessing
    {
        IProcessing FindMaxCostlyProcessing();
    }
}
