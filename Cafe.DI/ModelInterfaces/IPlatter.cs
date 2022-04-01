using Cafe.DI.Enums;

namespace Cafe.DI.ModelInterfaces
{
    public interface IPlatter
    {
        TypeOfProduct TypeOfProduct { get; }
        string Name { get; }
    }
}
