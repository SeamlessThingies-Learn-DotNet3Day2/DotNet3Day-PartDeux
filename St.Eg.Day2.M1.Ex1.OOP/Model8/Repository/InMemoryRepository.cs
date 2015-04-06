using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.M1.Ex1.OOP.Model8
{
    public class InMemoryRepository : IRepository
    {
        protected Dictionary<string, Customer> _customers = new Dictionary<string, Customer>();
        protected Dictionary<string, Order> _orders = new Dictionary<string, Order>(); 

        public virtual T Retrieve<T>(string id) where T : EntityBase
        {
            if (typeof(T) != typeof(Customer) && typeof(T) != typeof(Order))
            {
                throw new Exception("Repository does not yet support that type");    
            }
            if (typeof (T) == typeof (Customer))
            {
                return _customers[id] as T;
            }
            else
            {
                return _orders[id] as T;
            }
        }

        public virtual void Save<T>(T theItem) where T : EntityBase
        {
            if (typeof(T) != typeof(Customer) && typeof(T) != typeof(Order))
            {
                throw new Exception("Repository does not yet support that type");
            }
            if (typeof (T) == typeof (Customer))
            {
                _customers[theItem.ID] = theItem as Customer;
            }
            else
            {
                _orders[theItem.ID] = theItem as Order;
            }
        }

        public IEnumerable<Order> GetOrdersForCustomer(string customerID)
        {
            return _orders.Values.Where(o => o.Customer.ID == customerID);
        }
    }
}
