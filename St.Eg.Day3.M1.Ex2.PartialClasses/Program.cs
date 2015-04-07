using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace St.Eg.Day3.M1.Ex2.PartialClasses
{
    public partial class Partial
    {
        public string Name { get; set; }
        partial void enter();
        partial void exit();

        public Partial(string name)
        {
            Name = name;
        }

        public void print()
        {
            enter();
            Console.WriteLine(Name);
            exit();
        }
    }
    /*
    public partial class Partial
    {
    }
    */
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Partial("Mike");
            p.print();
            Console.ReadLine();
        }
    }
}
