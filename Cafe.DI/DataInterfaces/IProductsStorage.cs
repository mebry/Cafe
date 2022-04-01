using Cafe.DI.Enums;

namespace Cafe.DI.DataInterfaces
{
    public interface IIngredientsStorage : IData<(IIngredient, int)>
    {
        int NumberOfPlaces { get; }
        int MaxGrammingForOneIngredients { get; }
        IStorageConditions StorageConditions { get; }

        Tuple<IIngredient, int> GetIngredients(TypeOfIngredient typeOfIngredient, int numberOfGrams);
    }
}