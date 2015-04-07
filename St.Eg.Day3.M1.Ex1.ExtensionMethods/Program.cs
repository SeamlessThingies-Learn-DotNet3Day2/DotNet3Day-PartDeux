using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.Day3.M1.Ex1.ExtensionMethods
{
    class Program
    {
        // we will extend this class
        public sealed class Foo
        {
            public IEnumerable<int> Values { get; set; }

            public Foo(IEnumerable<int> values)
            {
                Values = values;
            }
        }

        /*
         * Create extension class here
         * Extend Foo to have a method calculating the cumulative sum of Values
         * */

        static void Main(string[] args)
        {
            var foo = new Foo(new[] {1, 2, 3, 4});
            //Console.WriteLine(foo.Values.CumSum());
        }
    }
}
