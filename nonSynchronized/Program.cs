using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nonSynchronized
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    int n = 0;
        //    var up = Task.Run(() =>
        //    {
        //        for (int i = 0; i < 100000; i++)
        //            n++;
        //    });

        //    for (int i = 0; i < 100000; i++)
        //        n--;

        //    up.Wait();
        //    Console.WriteLine(n);


        //    Console.ReadKey();
        //}

        static void Main(string[] args) //deadlock
        {
            int n = 0;
            object _lock = new object();


            var up = Task.Run(() =>
            {
                for (int i = 0; i < 100000; i++)
                    lock(_lock)
                        n++;
            });

            for (int i = 0; i < 100000; i++)
                lock(_lock)
                    n--;

            up.Wait();
            Console.WriteLine(n);


            Console.ReadKey();
        }
    }
}
