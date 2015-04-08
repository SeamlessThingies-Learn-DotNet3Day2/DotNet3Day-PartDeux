using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.M1.Ex1.ConsoleApp
{
    class Program
    {
        public class foo
        {
            private string _name;
            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            public string FirstName { get; private set; }

            public foo()
            {
                FirstName = "1";
            }
        }

        static void Main(string[] args)
        {
            var r = new foo();
            //r.FirstName = "";

            Console.WriteLine(r.Name);

            /*
            // TODO: create a while loop (always true)
            while (true)
            {
                // TODO: read from console, save in variable
                var data = Console.ReadLine();

                // TODO: write to console the contents of the variable
                Console.WriteLine(data);
            }
            */
        }
    }
}
