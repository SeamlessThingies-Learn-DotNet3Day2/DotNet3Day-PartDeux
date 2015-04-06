using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.M2.Ex3.Enumerables
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 10, 11, 12 };

            iterateWithEnum(array);
            iterateWithForEach(array);
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
