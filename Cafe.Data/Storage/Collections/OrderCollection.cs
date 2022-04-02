using Cafe.DI.Enums;
using Cafe.DI.Interfaces.Data;
using Cafe.DI.Interfaces.Models;
using Cafe.DI.Interfaces.Operation.Find;

namespace Cafe.Data
{
    /// <summary>
    /// The order collection class.
    /// </summary>
    public class OrderCollection : IData<IOrder>, IFindOrders
    {
        private readonly List<IOrder> _orders;

        /// <summary>
        /// Constructor for filling in data.
        /// </summary>
        /// <param name="ingredientsStorages"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public OrderCollection(List<IOrder> orders)
        {
            if (orders == null)
                throw new ArgumentNullException(nameof(orders));

            _orders = orders;
        }
        /// <summary>
        /// A method for adding one order.
        /// </summary>
        /// <param name="item"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Add(IOrder item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            _orders.Add(item);
        }

        /// <summary>
        /// A method for searching in a range divided into types of dishes.
        /// </summary>
        /// <param name="typeOfProduct"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public IEnumerable<IOrder> FindByRange(TypeOfProduct typeOfProduct, DateTime start, DateTime end)
        {
            List<IOrder> orders = new List<IOrder>();

            foreach (var order in _orders)
            {
                if (order.Date >= start && order.Date <= end &&
                    order.GetAll().ToList().TrueForAll(i => i.TypeOfProduct.Equals(typeOfProduct)))
                {
                    orders.Add(order);
                }
            }

            return orders;
        }

        public IEnumerable<Tuple<IIngredient, int>> FindMaxUsedIngredients()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tuple<IIngredient, int>> FindMinUsedIngredients()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The method for returning all objects.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IOrder> GetAll()
        {
            return _orders;
        }

        /// <summary>
        /// A method for removing one order.
        /// </summary>
        /// <param name="item"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Remove(IOrder item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            _orders.Remove(item);
        }
    }
}
