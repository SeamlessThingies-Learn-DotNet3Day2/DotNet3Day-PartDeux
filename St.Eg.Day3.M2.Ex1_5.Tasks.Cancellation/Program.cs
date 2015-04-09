using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace St.Eg.Day3.M2.Ex1_5.Tasks.Cancellation
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        #region completed
        static void cancellation()
        {
            var cts = new CancellationTokenSource();

            var task = Task.Factory.StartNew(
                () =>
                {
                    var i = 0;
                    while (!cts.Token.IsCancellationRequested)
                    {
                        i++;
                        Console.WriteLine("Before delay: {0}", i);
                        try
                        {
                            Task.Delay(10000, cts.Token).Wait();
                        }
                        catch (AggregateException ex)
                        {
                            Console.WriteLine("Cancellation exception caught");
                        }
                        Console.WriteLine("After delay: {0}", i);
                    }
                    Console.WriteLine("Saw signal to cancel");
                },
                cts.Token);

            Console.ReadLine();

            Console.WriteLine("Sending signal to cancel");
            cts.Cancel();
            Console.WriteLine("Waiting for task to complete");
            task.ContinueWith(i => Console.WriteLine("Completed"));
            task.Wait();

            Console.ReadLine();
        }
        #endregion
    }
}
