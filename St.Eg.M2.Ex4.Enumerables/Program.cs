using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.M2.Ex3.Enumerables
{
    public class Foo : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            foreach (var i in new int[] {100, 101, 102})
            {
                yield return i;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

//            var l = new LinkedList<int>();
            //l[0] = 1;

            var array = new []
            {
                1, 2, 3, 4, 5,
                10*20,
            };

            var oc = new ObservableCollection<int>(array);
            var incc = oc as INotifyCollectionChanged;
            incc.CollectionChanged += (sender, eventArgs) =>
            {

            };

            oc.Add(99);
            oc.RemoveAt(1);

            //foreach (var i in oc) Console.WriteLine(i);



            //var l = new List<int>(100);

            //Console.WriteLine(array.GetType());

            //Console.WriteLine(Array.BinarySearch(array, 3));

            //ICollection<int>

            //array.ToList().ForEach(i => Console.WriteLine(i));

            /*
            var array = new [] { 10, 11, 12 };
            var ie = array as IEnumerable<int>;
            if (ie != null) Console.WriteLine("Hey, I'm enumerable");

            var l = new List<int>(array);

            var enumerator = l.GetEnumerator(); //  ie.GetEnumerator();

            var next = enumerator.MoveNext();
            while (next)
            {
                var current = enumerator.Current;
                Console.WriteLine(current);
                l.Insert(2, -1);
                next = enumerator.MoveNext();
            }

            //foreach (var i in array) Console.WriteLine(i);

            //iterateWithEnum(array);
            //iterateWithForEach(array);
             * */
        }



        private static void iterateWithEnum(IEnumerable<int> array)
        {
            // TODO: get the enumerator
            var enumerator = array.GetEnumerator();
            // TODO: movenext
            //var moreItems = 

            // TODO: while move next
            //while (moreItems)
            //{
                // TODO: get the current item
                //var item = 
                // TODO: print the item
                //Console.WriteLine(item);
                // TODO: move next
                //moreItems = enumerator.MoveNext();
            //}
        }

        private static void iterateWithForEach(int[] array)
        {
            // TODO: foreach on every item
            {
//                Console.WriteLine(item);
            }
        }
    }
}
