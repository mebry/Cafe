using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Cafe.Data.Storage.Json;
using Cafe.Data.Storage.Converters;
using Cafe.DI.ModelInterfaces;
using Cafe.DI.Enums;
using Cafe.Bll;
namespace Cafe.Tests
{
    [TestClass]
    public class GetData
    {
        public const string OrderJsonPath = "OrdersStorage.json";
        public static List<IPlatter> GetPlatters()
        {
            var platters = new List<IPlatter>();

            platters.Add(new Platter(TypeOfProduct.Drink, "Moxito", 100));
            platters.Add(new Platter(TypeOfProduct.Drink, "Juice", 120));
            platters.Add(new Platter(TypeOfProduct.Drink, "Water", 5));
            
            return  platters;
        }
        public static List<IOrder> GetOrders()
        {
            var orders = new List<IOrder>();

            orders.Add(new Order(1, new System.DateTime(2021, 12, 10), GetPlatters()));
            orders.Add(new Order(2, new System.DateTime(2020, 11, 10), GetPlatters()));

            return orders;
        }
        [TestMethod]
        public void GetOrderJsonData()
        {
            OrderJsonData orderJsonData = new OrderJsonData(OrderJsonPath, GetOrders());
            orderJsonData.Read();
        }
        [TestMethod]
        public void GetOrderJsonData2()
        {
            OrderJsonData orderJsonData = new OrderJsonData(OrderJsonPath, new List<IOrder>());
            orderJsonData.Restore(new OrderConverter(),new PlatterConverter());
            int count = orderJsonData.GetAll().Count();
            Assert.IsTrue(2 == count);
        }
    }
}