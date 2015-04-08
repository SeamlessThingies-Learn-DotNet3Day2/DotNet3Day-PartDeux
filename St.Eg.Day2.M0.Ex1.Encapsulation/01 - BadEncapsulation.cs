using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.Day2.M0.Ex1.Encapsulation.ex01
{
    public class BadEncapsulation
    {
        // I can be modified by derived classes
        protected int _someState;

        // I can be modified by anything
        public int _someOtherState;

        public BadEncapsulation(){}
    }

    public class Derived : BadEncapsulation
    {
        public Derived(){}

        public void IWillMessThingsUp()
        {
            _someState = 10;

            // code in the base can now be inconsisten
        }
    }
}
