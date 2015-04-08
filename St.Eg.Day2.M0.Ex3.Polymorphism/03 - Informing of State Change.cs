using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.Day2.M0.Ex4.Polymorphism.ex03
{
    public class Abstraction {
        private int _someState;

        private void algorithm() {
            // do something that changes private state
            _someState++;

            informedDerivationOfStateChange();
        }

        protected virtual void informedDerivationOfStateChange() { }
    }

    public class Derived : Abstraction {
        protected override void informedDerivationOfStateChange() {
            // do someting as an important thing happened in
            // my base class
        }
    }
}

