using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.M1.Ex1.OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //model7();  // each class has its own repository type
            model8(); // one common repository
        }

        private static void model7()
        {
            var repository = new Model7.InMemoryRepository();

            var customer1 = new Model7.Customer()
            {
                ID = "1",
                Name = "Mike",
            };
            
            repository.Save(customer1);

            var customer2 = repository.Retrieve<Model7.Customer>("1");
        }

        private static void model8()
        {
            var repository = new Model8.InMemoryRepository();

            var customer1 = new Model8.Customer()
            {
                ID = "1",
                Name = "Mike",
            };

            var order1 = new Model8.Order()
            {
                Customer = customer1,
                ID = "2"
            };

            var order2 = new Model8.Order()
            {
                Customer = customer1,
                ID = "3"
            };

            repository.Save(order1);
            repository.Save(order2);
            repository.Save(customer1);

            var retrievedCustomer = repository.Retrieve<Model8.Customer>("1");
            var retrievedOrders = repository.GetOrdersForCustomer(retrievedCustomer.ID);

            Assert.AreEqual(retrievedCustomer.ID, customer1.ID);
            Assert.AreEqual(retrievedCustomer.Name, customer1.Name);

            Assert.AreEqual(retrievedOrders.ElementAt(0).ID, order1.ID);
            Assert.AreEqual(retrievedOrders.ElementAt(1).ID, order2.ID);

            Console.WriteLine("All tests passed");
        }
    }
}
