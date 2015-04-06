using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.M1.Ex1.OOP.Model5
{
    public class Customer : EntityBase
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string HomeAddress { get; set; }
        public string WorkAddress { get; set; }

        public override void Validate()
        {
            base.Validate();

            if (string.IsNullOrEmpty(Name)) throw new Exception("Customer needs a name");
            if (string.IsNullOrEmpty(EmailAddress)) throw new Exception("Customer needs an email address");
            if (string.IsNullOrEmpty(HomeAddress)) throw new Exception("Customer needs a home address");
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }

        public override void Retrieve(string ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetOrders()
        {
            throw new NotImplementedException();
        }
    }
}
