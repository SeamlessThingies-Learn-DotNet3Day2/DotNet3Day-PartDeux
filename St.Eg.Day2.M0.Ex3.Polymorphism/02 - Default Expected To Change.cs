using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.Day2.M0.Ex4.Polymorphism.x02
{
    public abstract class Abstraction {
        private void algorithm(){
            doThis();
            doThat();
            process(1);
            doSomethingElse();
        }
        private void doThis() { }
        private void doThat() { }
        private void doSomethingElse() { }

        public virtual void process(int someData){
            // default processing
        }
    }

    public class Derived : Abstraction {
        public override void process(int someData) {
            // I do something else with this data than what
            // is the default of the abstraction
            base.process(someData);
        }
    }
}
