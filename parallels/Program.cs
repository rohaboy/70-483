using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace parallels
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Parallel.For(0, 10, i =>
        //    {
        //        Thread.Sleep(1000);
        //    });

        //    var numbers = Enumerable.Range(0, 10);
        //    Parallel.ForEach(numbers, i =>
        //    {
        //        Thread.Sleep(1000);
        //    });

        //    Console.ReadKey();
        //}

        static void Main(string[] args)
        {
            ParallelLoopResult result = Parallel.For(0, 1000, (int i, ParallelLoopState loopState) =>
              {
                  
                  if (i == 1000)
                  {
                      Console.WriteLine("Breaking loop...");
                      loopState.Break();
                  }
                  i++;
              });

            

            Console.ReadKey();
        }
    }
}
