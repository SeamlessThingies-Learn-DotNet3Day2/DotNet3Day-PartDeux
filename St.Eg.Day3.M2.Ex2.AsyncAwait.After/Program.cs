using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.Day3.M2.Ex2.AsyncAwait.After
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            //program.exercise1();
            program.exercise2();

            Console.ReadLine();
        }

        async public void exercise1()
        {
            Console.WriteLine("in exercise1");
            await thisMethodWillBeRunAsync();
            Console.WriteLine("after calling async method");
        }

        async public Task thisMethodWillBeRunAsync()
        {
            Console.WriteLine("async method running");
            Task.Delay(5000).Wait();
            Console.WriteLine("async method ending");
        }

        public void exercise2()
        {
            Console.WriteLine("in exercise2");
            var task = Task.Factory.StartNew(
                () =>
                {
                    Console.WriteLine("in task");

                    Task.Factory.StartNew(() => thisMethodWillBeRunAsync()).Wait();

                    Console.WriteLine("after calling async method");
                });
            task.ContinueWith(a => Console.WriteLine("After running the task"));
            task.Wait();

            Console.WriteLine("Leaving exercise2");
        }
    }
}
