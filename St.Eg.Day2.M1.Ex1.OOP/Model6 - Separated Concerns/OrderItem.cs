using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.M1.Ex1.OOP.Model6
{
    public class OrderItem : EntityBase
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double PriceAtPurchase { get; set; }
    }
}
