using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.M1.Ex1.OOP.Model5
{
    public class Product : EntityBase
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double CurrentPrice { get; set; }

        public override void Validate()
        {
            base.Validate();
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
