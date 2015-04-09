using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.M1.Ex1.OOP.Model7
{
    public class InMemoryRepository : IRepository
    {
        protected Dictionary<string, Customer> _customers = new Dictionary<string, Customer>();
        
        public virtual T Retrieve<T>(string id) where T : EntityBase
        {
            if (typeof(T) != typeof(Customer))
            {
                throw new Exception("Repository does not yet support that type");    
            }
            return _customers[id] as T;
        }

        public virtual void Save<T>(T theItem) where T : EntityBase
        {
            if (typeof(T) != typeof(Customer))
            {
                throw new Exception("Repository does not yet support that type");
            }
            _customers[theItem.ID] = theItem as Customer;
        }
    }
}
