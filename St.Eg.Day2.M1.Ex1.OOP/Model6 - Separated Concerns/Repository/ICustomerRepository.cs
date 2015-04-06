using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using St.Eg.M1.Ex1.OOP.Model6;

namespace St.Eg.M1.Ex1.OOP.Model6
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        IEnumerable<Order> GetOrders();
    }
}
