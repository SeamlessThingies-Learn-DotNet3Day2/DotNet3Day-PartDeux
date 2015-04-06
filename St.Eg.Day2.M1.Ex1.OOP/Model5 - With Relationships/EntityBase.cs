using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.M1.Ex1.OOP.Model5
{
    public abstract class EntityBase
    {
        public string ID { get; set; }

        public virtual void Validate()
        {
            if (string.IsNullOrEmpty(ID)) throw new Exception();
        }

        public abstract void Retrieve(string ID);
        public abstract void Save();
    }
}
