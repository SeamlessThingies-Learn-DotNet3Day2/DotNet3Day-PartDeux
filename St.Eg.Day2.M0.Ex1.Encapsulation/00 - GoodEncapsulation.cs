using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.Day2.M0.Ex1.Encapsulation.ex00
{
    public class GoodEncapsulation
    {
        // I can't be seen outside this clas
        // OR by derived classes
        private int _someState;

        public GoodEncapsulation()
        {
        }
    }

    public class Derived : GoodEncapsulation
    {
        // I have no access to _someState
        // Derived classes should not know of 
        // state in the base classes
    }
}
