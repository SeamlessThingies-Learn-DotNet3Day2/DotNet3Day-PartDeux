using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.EgDay3.M2.Ex0.AddedForLinq
{
    class Program
    {
        public class Foo
        {
            // ADDED: Automatic properties
            public string AutoProperty1 { get; set; }
            public string AutoProperty2 { get; set; }
        }

        static void Main(string[] args)
        {
            // ADDED: type inference
            var i = 1;

            // BECAUSE: we can't specify a projected anonymous classes type

            // ADDED: anonymous classes
            var f = new { Prop1 = "A", Prop2 = "B" };
            
            // BECAUSE: we need to project types 

            // ADDED: Collection initializers
            var list = new List<Foo>()
            {
                new Foo() { AutoProperty1 = "1", AutoProperty2 = "2"},
                new Foo() { AutoProperty1 = "3", AutoProperty2 = "4"}
            };

            // ADDED: lambda functions
            Func<double, double> lf = x => x*x;

            // BECAUSE: we need to initialized collections from projections

            // ADDED: Projection
            // this also uses anonymous classes, autoprop, collection intializer, type inference
            // and lambda functions, extension methods (.Select)
            var projected = list.Select(e => new {AutoProp = int.Parse(e.AutoProperty1)});
            Console.WriteLine(projected.FirstOrDefault().AutoProp.GetType());


            // ADDED: expression trees
            // projected is treated underneat as an exp tree
        }
    }
}
