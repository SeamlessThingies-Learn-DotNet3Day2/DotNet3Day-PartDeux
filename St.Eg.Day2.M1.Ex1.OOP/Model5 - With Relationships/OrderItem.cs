using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.M1.Ex1.OOP.Model5
{
    public class OrderItem : EntityBase
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double PriceAtPurchase { get; set; }

        public override void Validate()
        {
            base.Validate();

            if (Product == null) throw new Exception("OrderItem needs a Product");
            if (Quantity == 0) throw new Exception("OrderItem needs a quantitiy > 0");
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
