using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.M2.Ex3.Enumerables.After
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] {10, 11, 12};

            iterateWithEnum(array);
            iterateWithForEach(array);
        }

        private static void iterateWithEnum(IEnumerable<int> array)
        {
            var enumerator = array.GetEnumerator();
            var moreItems = enumerator.MoveNext();
            while (moreItems)
            {
                var item = enumerator.Current;
                Console.WriteLine(item);
                moreItems = enumerator.MoveNext();
            }
        }

        private static void iterateWithForEach(int[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
