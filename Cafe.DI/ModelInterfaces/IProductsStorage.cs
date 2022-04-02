using Cafe.DI.Enums;
using Cafe.DI.DataInterfaces;

namespace Cafe.DI.ModelInterfaces
{
    public interface IIngredientsStorage : IData<Tuple<IIngredient, int>>
    {
        int NumberOfPlaces { get; }
        int MaxGrammingForOneIngredients { get; }
        IStorageConditions StorageConditions { get; }

        Tuple<IIngredient, int> GetIngredients(TypeOfIngredient typeOfIngredient, int numberOfGrams);
    }
}