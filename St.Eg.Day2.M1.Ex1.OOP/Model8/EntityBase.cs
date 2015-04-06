using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.M1.Ex1.OOP.Model8
{
    public abstract class EntityBase
    {
        public string ID { get; set; }

        public EntityBase()
        {
            ID = Guid.NewGuid().ToString();
        }
    }
}
