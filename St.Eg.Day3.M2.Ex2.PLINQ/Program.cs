using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace St.Eg.Day3.M2.Ex2.PLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Enumerable.Range(0, 100);

            var count = 0;
            var query = data.AsParallel().WithDegreeOfParallelism(5)
                        .Select(i =>
                            {
                                Interlocked.Increment(ref count);
                                Console.WriteLine("Starting task: {0}", count);
                                Task.Delay(500).Wait();
                                Console.WriteLine("Exiting task: {0}", count);
                                return i * i;
                            });
            var results = query.ToList();
            results.ForEach(r => Console.WriteLine(r));
        }
    }
}
