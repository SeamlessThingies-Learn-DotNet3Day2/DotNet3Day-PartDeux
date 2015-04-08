using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.Day2.M0.Ex3.Inheritance
{
    public class Abstraction
    {
        public string Property1 { get; set; }
    }

    public class Derivation : Abstraction
    {
        public int Property2 { get; set; }
    }
}
