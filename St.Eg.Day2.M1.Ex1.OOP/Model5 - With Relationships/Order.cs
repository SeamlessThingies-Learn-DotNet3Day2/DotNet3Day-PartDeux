using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.M1.Ex1.OOP.Model5
{
    public class Order : EntityBase
    {
        public Customer Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShippingAddress { get; set; }
        public IEnumerable<OrderItem> OrderItems { get; set; }
        public override void Validate()
        {
            base.Validate();

            if (Customer == null) throw new Exception("Order needs a customer");
            if (OrderDate == null) throw new Exception("Order needs a order date");
            if (OrderItems == null || OrderItems.Count() == 0) throw new Exception("Order needs order items");
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }

        public override void Retrieve(string ID)
        {
            throw new NotImplementedException();
        }
    }
}
