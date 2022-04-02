using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Cafe.Data.Storage.Json;
using Cafe.DI.Interfaces.Operation.Processing;
using Cafe.DI.Interfaces.Models;
using Cafe.DI.Enums;
using Cafe.Bll.Models;
using Cafe.DI.Interfaces.Recipe;

namespace Cafe.Tests.TestData
{
    public class GetData
    {
        public static string OrderJsonPath = "OrdersStorage.json";
        public static string IngredientsStorageJsonPath = "IngredientsStorage.json";
        public static string RecipeJsonDataPath = "RecipeStorage.json";
        public static string ProcessingJsonDataPath = "ProcessingStorage.json";

        public static List<IIngredient> GetIngredients()
        {
            var ingredients = new List<IIngredient>();

            ingredients.Add(new Ingredient(1, TypeOfIngredient.Water, new Conditions(10, 30)));
            ingredients.Add(new Ingredient(20, TypeOfIngredient.Sugar, new Conditions(0, 30)));
            ingredients.Add(new Ingredient(40, TypeOfIngredient.Chicken, new Conditions(15, 19)));
            ingredients.Add(new Ingredient(10, TypeOfIngredient.Mayonnaise, new Conditions(10, 20)));

            return ingredients;
        }

        public static List<(IIngredient, int)> GetTupleIngredients()
        {
            var ingredients = new List<(IIngredient, int)>();

            ingredients.Add((new Ingredient(1, TypeOfIngredient.Water, new Conditions(10, 30)), 10));
            ingredients.Add((new Ingredient(20, TypeOfIngredient.Sugar, new Conditions(0, 30)), 20));
            ingredients.Add((new Ingredient(40, TypeOfIngredient.Chicken, new Conditions(15, 19)), 30));
            ingredients.Add((new Ingredient(10, TypeOfIngredient.Mayonnaise, new Conditions(10, 20)), 40));

            return ingredients;
        }

        public static IStorageConditions GetStandartConditions() => new Conditions(-10, 30);

        public static List<IIngredientsStorage> GetIngredientsStorages()
        {
            var storages = new List<IIngredientsStorage>();

            storages.Add(new IngredientsStorage(GetTupleIngredients(), 100, 1000, GetStandartConditions()));
            storages.Add(new IngredientsStorage(GetTupleIngredients(), 200, 2000, GetStandartConditions()));
            storages.Add(new IngredientsStorage(GetTupleIngredients(), 300, 3000, GetStandartConditions()));

            return storages;
        }

        public static List<IPlatter> GetPlatters()
        {
            var platters = new List<IPlatter>();

            platters.Add(new Platter(TypeOfProduct.Drink, "Moxito", 100));
            platters.Add(new Platter(TypeOfProduct.Drink, "Juice", 120));
            platters.Add(new Platter(TypeOfProduct.Drink, "Water", 5));

            return platters;
        }

        public static List<IOrder> GetOrders()
        {
            var orders = new List<IOrder>();

            orders.Add(new Order(1, new System.DateTime(2021, 12, 10), GetPlatters()));
            orders.Add(new Order(2, new System.DateTime(2020, 11, 10), GetPlatters()));

            return orders;
        }

        public static List<ICookingStep> GetCookingSteps()
        {
            var steps = new List<ICookingStep>();

            steps.Add(new CookingStep((ProcessingType.Connect,
                new System.TimeSpan(0, 0, 10)), GetTupleIngredients(), new System.TimeSpan(0, 0, 20)));

            steps.Add(new CookingStep((ProcessingType.Mix,
                new System.TimeSpan(0, 0, 20)), GetTupleIngredients(), new System.TimeSpan(0, 0, 30)));

            steps.Add(new CookingStep((ProcessingType.Stew,
                new System.TimeSpan(0, 0, 20)), GetTupleIngredients(), new System.TimeSpan(0, 0, 40)));

            return steps;
        }

        public static List<IRecipe> GetRecipes()
        {
            var recipes = new List<IRecipe>();

            recipes.Add(new Recipe(1000, "Tiramisu",
                TypeOfProduct.Dish, GetCookingSteps(), GetTupleIngredients()));

            recipes.Add(new Recipe(800, "Sushi",
                TypeOfProduct.Dish, GetCookingSteps(), GetTupleIngredients()));

            recipes.Add(new Recipe(300, "Fruit juice",
                TypeOfProduct.Drink, GetCookingSteps(), GetTupleIngredients()));

            return recipes;
        }

        public static List<IProcessing> GetProcessing()
        {
            var processing = new List<IProcessing>();

            processing.Add(new Processing(10, new System.TimeSpan(0, 0, 0, 0, 10), ProcessingType.Mix));
            processing.Add(new Processing(20, new System.TimeSpan(0, 0, 0, 0, 15), ProcessingType.Toasting));
            processing.Add(new Processing(30, new System.TimeSpan(0, 0, 0, 0, 20), ProcessingType.Connect));
            processing.Add(new Processing(40, new System.TimeSpan(0, 0, 0, 0, 30), ProcessingType.Bake));

            return processing;
        }
    }
}