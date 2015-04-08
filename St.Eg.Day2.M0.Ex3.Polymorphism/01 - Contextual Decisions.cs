using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.Day2.M0.Ex4.Polymorphism.x01
{
    public abstract class Abstraction {
        // template method for derived classes to implement
        protected abstract bool helpsMakeDecision(int someState);

        private int _someState;

        private void someAlgorithm() {
            // what I do depends on derivations deciding
            if (helpsMakeDecision(_someState)){
                // do this
            } else {
                // or do this
            }
        }
    }

    public class Derivation : Abstraction {
        protected override bool helpsMakeDecision(int someState) {
            // some decision that needs to be made
            return someState < 10;
        }
    }
}
