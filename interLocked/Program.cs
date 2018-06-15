using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace interLocked
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            var up = Task.Run(() =>
            {
                for (int i = 0; i < 100000; i++)
                    Interlocked.Increment(ref n); //atomic
            });

            for (int i = 0; i < 100000; i++)
                Interlocked.Decrement(ref n); //atomic

            up.Wait();
            Console.WriteLine(n);


            Console.ReadKey();
        }
    }
}
