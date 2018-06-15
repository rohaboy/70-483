using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task t = Task.Run(() =>
            //{
            //    for (int x = 0; x < 100; x++)
            //    {
            //        Console.Write('*');
            //    }
            //});

            //t.Wait();
            ////Console.ReadKey();

            //Task<int> t1 = Task.Run(() =>
            //{
            //    return 100;
            //});

            //Console.WriteLine(t1.Result);

            //Console.ReadLine();

            Task<int> t = Task.Run(() =>
            {
                return 42;
            }).ContinueWith((i) =>
            {
                return i.Result * 2;
            });

            Console.WriteLine(t.Result);

            Console.ReadKey();

        }
    }
}
