using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 100);
            var parallelResult = numbers.AsParallel().AsOrdered().WithExecutionMode(ParallelExecutionMode.ForceParallelism)
                                         .WithDegreeOfParallelism(10)
                                        .Where(i => i % 2 == 0)
                                        .ToArray();

            foreach (int i in parallelResult)
                Console.WriteLine(i);



            Console.ReadKey();

        }
    }
}
