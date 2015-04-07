using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.Day3.M2.Ex1.LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            minmaxothers();
            //enumerableQuery();
            //enumerableQueryWithSelection();
            //enumerableQueryWithOrdering();

            //compQuery();
            //compQueryWithSelection();
            //compQueryWithOrdering();

            //demonstrateDeferred();
            //expressionTree();
            //expressionTree2();

            //projection();

            // aggregation

            //filteredGroups();
            //sumItemsInGroups();
        }

        #region exercises

        public class ExampleGroupItem
        {
            public string Tag { get; set; }
            public int Value { get; set; }
        }

        private static void sumItemsInGroups()
        {
            var items = new[]
            {
                new ExampleGroupItem() { Tag = "A", Value = 1},
                new ExampleGroupItem() { Tag = "B", Value = 2},
                new ExampleGroupItem() { Tag = "B", Value = 3},
                new ExampleGroupItem() { Tag = "C", Value = 4},
                new ExampleGroupItem() { Tag = "C", Value = 5},
                new ExampleGroupItem() { Tag = "C", Value = 6},
                new ExampleGroupItem() { Tag = "D", Value = 7},
                new ExampleGroupItem() { Tag = "D", Value = 8},
                new ExampleGroupItem() { Tag = "D", Value = 9},
            };

            var query =
                from i in items
                group i by i.Tag
                into buckets
                select new
                {
                    Tag = buckets.Key,
                    Sum = buckets.Sum(v => v.Value)
                };

            foreach (var bucket in query)
            {
                Console.WriteLine("{0} {1}", bucket.Tag, bucket.Sum);
            }
        }

        #endregion

        #region examples

        #region enumerable

        private static void enumerableQuery()
        {
            var names = new [] { "Tom", "Dick", "Harry", "Mary", "Jay" };

            var query = names.Select(n => n.ToUpper());

            query.ToList().ForEach(i => Console.WriteLine(i));
        }
        
        private static void enumerableQueryWithSelection()
        {
            var names = new[] { "Tom", "Dick", "Harry", "Mary", "Jay" };

            var query = names
                .Where(i => i.Contains("a"))
                .Select(n => n.ToUpper());

            query.ToList().ForEach(i => Console.WriteLine(i));

        }
        
        private static void enumerableQueryWithOrdering()
        {
            var names = new[] { "Tom", "Dick", "Harry", "Mary", "Jay" };

            var query = names
                .Where(i => i.Contains("a"))
                .OrderBy(i => i.Length)
                .Select(n => n.ToUpper());

            query.ToList().ForEach(i => Console.WriteLine(i));
        }

        #endregion

        #region aggregation and quantification

        private static void minmaxothers()
        {
            var items = Enumerable.Range(0, 100);
            Console.WriteLine("Max: {0}", items.Max());
            Console.WriteLine("Min: {0}", items.Min());
            Console.WriteLine("Average: {0}", items.Average());
            Console.WriteLine("Count: {0}", items.Count());
            Console.WriteLine("Sum: {0}", items.Sum());
            Console.WriteLine("Any > 10: {0}", items.Any(x => x > 10));
            Console.WriteLine("All positive: {0}", items.All(x => x > 0));
        }
        #endregion

        #region comprehension queries
        private static void compQuery()
        {
            var names = new[] { "Tom", "Dick", "Harry", "Mary", "Jay" };

            var query = from name in names
                select name;

            query.ToList().ForEach(i => Console.WriteLine(i));
        }

        private static void compQueryWithSelection()
        {
            var names = new[] { "Tom", "Dick", "Harry", "Mary", "Jay" };

            var query = from name in names
                        where name.Contains("a")
                        select name;

            query.ToList().ForEach(i => Console.WriteLine(i));

        }

        private static void compQueryWithOrdering()
        {
            var names = new[] { "Tom", "Dick", "Harry", "Mary", "Jay" };

            var query = from name in names
                        where name.Contains("a")
                        orderby name.Length
                        select name;

            query.ToList().ForEach(i => Console.WriteLine(i));
        }
        #endregion
        
        #region expression trees and deferred execution
        private static void demonstrateDeferred()
        {
            var names = new[] { "Tom", "Dick", "Harry", "Mary", "Jay" };

            var query = names.ThisIsDeferred();

            Console.WriteLine("Query created, but not run yet");

            // this fires it off
            query.ToList();
        }

        private static void expressionTree()
        {
            var names = new[] { "Tom", "Dick", "Harry", "Mary", "Jay" };

            var query = names.ThisIsDeferred().AsQueryable();
            Console.WriteLine(query.GetType());
            Console.WriteLine(query.Expression);
        }

        private static void expressionTree2()
        {
            // Creating a parameter expression.
            ParameterExpression value = Expression.Parameter(typeof(int), "value");

            // Creating an expression to hold a local variable. 
            ParameterExpression result = Expression.Parameter(typeof(int), "result");

            // Creating a label to jump to from a loop.
            LabelTarget label = Expression.Label(typeof(int));

            // Creating a method body.
            BlockExpression block = Expression.Block(
                // Adding a local variable. 
                new[] { result },
                // Assigning a constant to a local variable: result = 1
                Expression.Assign(result, Expression.Constant(1)),
                // Adding a loop.
                    Expression.Loop(
                // Adding a conditional block into the loop.
                       Expression.IfThenElse(
                // Condition: value > 1
                           Expression.GreaterThan(value, Expression.Constant(1)),
                // If true: result *= value --
                           Expression.MultiplyAssign(result,
                               Expression.PostDecrementAssign(value)),
                // If false, exit the loop and go to the label.
                           Expression.Break(label, result)
                       ),
                // Label to jump to.
                   label
                )
            );

            // Compile and execute an expression tree. 
            int factorial = Expression.Lambda<Func<int, int>>(block, value).Compile()(5);

            Console.WriteLine(factorial);

        }

        #endregion

        #region Projections
        class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Pet
        {
            public string Name { get; set; }
            public Person Owner { get; set; }
        }
        
        private static void projection()
        {
            var customers = new[]
            {
                new Person() {FirstName = "Michael", LastName = "Heydt"},
                new Person() {FirstName = "Marcia", LastName = "Heydt"}
            };

            var onlyAges = customers.Select(c => c.FirstName);
            onlyAges.ToList().ForEach(r => Console.WriteLine(r));
        }

        #endregion

        #region joins

        public static void LeftOuterJoinExample()
        {
            var magnus = new Person { FirstName = "Magnus", LastName = "Hedlund" };
            var terry = new Person { FirstName = "Terry", LastName = "Adams" };
            var charlotte = new Person { FirstName = "Charlotte", LastName = "Weiss" };
            var arlene = new Person { FirstName = "Arlene", LastName = "Huff" };

            var barley = new Pet { Name = "Barley", Owner = terry };
            var boots = new Pet { Name = "Boots", Owner = terry };
            var whiskers = new Pet { Name = "Whiskers", Owner = charlotte };
            var bluemoon = new Pet { Name = "Blue Moon", Owner = terry };
            var daisy = new Pet { Name = "Daisy", Owner = magnus };

            // Create two lists.
            var people = new List<Person> { magnus, terry, charlotte, arlene };
            var pets = new List<Pet> { barley, boots, whiskers, bluemoon, daisy };

            var query = from person in people
                        join pet in pets on person equals pet.Owner into gj
                        from subpet in gj.DefaultIfEmpty()
                        select new { person.FirstName, PetName = (subpet == null ? String.Empty : subpet.Name) };

            foreach (var v in query)
            {
                Console.WriteLine("{0,-15}{1}", v.FirstName + ":", v.PetName);
            }
        }

        public static void InnerJoinExample()
        {
            var magnus = new Person { FirstName = "Magnus", LastName = "Hedlund" };
            var terry = new Person { FirstName = "Terry", LastName = "Adams" };
            var charlotte = new Person { FirstName = "Charlotte", LastName = "Weiss" };
            var arlene = new Person { FirstName = "Arlene", LastName = "Huff" };
            var rui = new Person { FirstName = "Rui", LastName = "Raposo" };

            var barley = new Pet { Name = "Barley", Owner = terry };
            var boots = new Pet { Name = "Boots", Owner = terry };
            var whiskers = new Pet { Name = "Whiskers", Owner = charlotte };
            var bluemoon = new Pet { Name = "Blue Moon", Owner = rui };
            var daisy = new Pet { Name = "Daisy", Owner = magnus };

            // Create two lists.
            var people = new List<Person> { magnus, terry, charlotte, arlene, rui };
            var pets = new List<Pet> { barley, boots, whiskers, bluemoon, daisy };

            // Create a collection of person-pet pairs. Each element in the collection 
            // is an anonymous type containing both the person's name and their pet's name. 
            var query = from person in people
                        join pet in pets on person equals pet.Owner
                        select new { OwnerName = person.FirstName, PetName = pet.Name };

            foreach (var ownerAndPet in query)
            {
                Console.WriteLine("\"{0}\" is owned by {1}", ownerAndPet.PetName, ownerAndPet.OwnerName);
            }
        }

        #endregion

        #region Grouping

        private static void groupBy()
        {
            string[] files = Directory.GetFiles(Path.GetTempPath()).Take(100).ToArray();

            IEnumerable<IGrouping<string, string>> query =
                files.GroupBy(file => Path.GetExtension(file));

            foreach (IGrouping<string, string> grouping in query)
            {
                Console.WriteLine("Extension: " + grouping.Key);
                Console.WriteLine("# of items: " + grouping.Count());

                foreach (string filename in grouping)
                    Console.WriteLine("   - " + filename);
            }
        }

        private static void filteredGroups()
        {
            string[] files = Directory.GetFiles(Path.GetTempPath()).Take(100).ToArray();
            var query = from file in files
                group file.ToUpper() by Path.GetExtension(file)
                into grouping
                where grouping.Count() < 5
                select grouping;
            foreach (var grouping in query)
            {
                Console.WriteLine("Extension: " + grouping.Key);
                Console.WriteLine("# of items: " + grouping.Count());
            }
        }

        #endregion
        #endregion

    }
    #region simple extension methods

    public static class ProveDeferment
    {
        public static IEnumerable<string> ThisIsDeferred(this IEnumerable<string> values)
        {
            foreach (var v in values)
            {
                Console.WriteLine(v);
                yield return v;
            }
        }
    }
    #endregion
}
