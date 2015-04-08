using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.Day3.M2.Ex2.AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            //program.exercise1();
            //program.exercise2();

            Console.ReadLine();
        }

        // TODO: mark as async
        public void exercise1()
        {
            Console.WriteLine("in exercise1");
            // TODO: await calling thisMethodWillBeRunAsync()
            Console.WriteLine("after calling async method");
        }

        // TODO: mark as async
        // TODO: change return value
        public void thisMethodWillBeRunAsync()
        {
            Console.WriteLine("async method running");
            Task.Delay(5000).Wait();
            Console.WriteLine("async method ending");
        }

        public void exercise2()
        {
            Console.WriteLine("in exercise2");
            
            
            //var task = // TODO: Create a task that delays for five seconds
                //() =>
                {
                    Console.WriteLine("in task");

                    // TODO: Run a task to delay for five seconds
                    

                    Console.WriteLine("after calling async method");
                }//);
            // TODO: add a continuation that writes to the console
            // TODO: wait for the main task to finish

            Console.WriteLine("Leaving exercise2");
        }
    }
}
