using Cafe.DI.Enums;

namespace Cafe.DI.ModelInterfaces
{
    public interface IIngredient
    {
        int Price { get; }
        TypeOfIngredient TypeOfIngredient { get; }
        IStorageConditions StorageConditions { get; }
    }
}
