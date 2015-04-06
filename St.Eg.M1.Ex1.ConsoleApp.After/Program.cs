using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.M1.Ex1.ConsoleApp.After
{
    internal class Program
    {
        private static int i = 1;
        static void Main()
        {
            while (i<5)
            {
                Console.Write("In[{0}]: ", i);
                var input = Console.ReadLine();
                Console.WriteLine("Out[{0}] {1}", i, input);
                i++;
            }
        }
    }
}
